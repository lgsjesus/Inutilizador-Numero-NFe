using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;

namespace Inutilizador_Numero_NFe
{
    public class AssinarXML
    {
        public static XmlElement AssinarXmlNfe(string arquivo, string uriReferenciaAssinatura, bool escreverAssinaturaArquivo, X509Certificate2 certificado)
        {
            #region Validações dos parâmetros da chamada
            if (arquivo == "" || !File.Exists(arquivo))
            {
                throw new Exception(String.Format("Arquivo {0} inexistente.", arquivo));
            }
            if (uriReferenciaAssinatura == "")
            {
                throw new Exception("URI não informada.");
            }
            #endregion

            // Lê o arquivo e gera o XML que será assinado
            #region Lê o arquivo e gera o XML que será assinado
            XmlDocument xmlDocAssinado = new XmlDocument();
            xmlDocAssinado.PreserveWhitespace = false;
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(arquivo);
                xmlDocAssinado.LoadXml(sr.ReadToEnd());
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Não foi possível acessar o arquivo XML da NF-e.\n{0}", ex.Message));
            }
            finally
            {
                sr.Close();
            }
            #endregion

            XmlElement xmlAssinatura = AssinarXmlNfe(xmlDocAssinado, uriReferenciaAssinatura, certificado);

            // Grava o XML assinado
            #region Grava o XML assinado
            if (escreverAssinaturaArquivo)
            {
                // Adiciona o elemento assinatura no final do DocumentElement
                xmlDocAssinado.DocumentElement.AppendChild(xmlDocAssinado.ImportNode(xmlAssinatura, true));

                // Escreve o XML assinado em arquivo
                StreamWriter sw = null;
                try
                {
                    File.Delete(arquivo);
                    sw = File.CreateText(arquivo);
                    sw.Write(xmlDocAssinado.InnerXml);
                }
                catch (Exception ex)
                {
                    throw new Exception(String.Format("Não foi possível gravar o arquivo XML assinado da NF-e.\n{0}", ex.Message));
                }
                finally
                {
                    sw.Close();
                }
            }
            #endregion

            return xmlAssinatura;
        }

        public static XmlElement AssinarXmlNfe(XmlDocument xmlDocAssinado, string uriReferenciaAssinatura, X509Certificate2 certificado)
        {
            XmlElement xmlAssinatura = null;
          

            // Valida o URI
            #region Valida o URI
          
            try
            {
                // Verifica se a tag a ser assinada existe é única
                int qtdeRefUri = xmlDocAssinado.GetElementsByTagName(uriReferenciaAssinatura).Count;
                if (qtdeRefUri == 0)
                {
                    throw new Exception("A tag de assinatura " + uriReferenciaAssinatura.Trim() + " inexiste.");
                }
                else if (qtdeRefUri > 1)
                {
                    throw new Exception("A tag de assinatura " + uriReferenciaAssinatura.Trim() + " não é unica.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("XML mal formado - " + ex.Message);
            }
            #endregion

            // Assina o XML
            #region Assina o XML
          
            try
            {
                // Create a SignedXml object.
                SignedXml signedXml = new SignedXml(xmlDocAssinado);

                // Add the key to the SignedXml document
                signedXml.SigningKey = certificado.PrivateKey;

                // Create a reference to be signed
                Reference reference = new Reference();

                // Localiza o URI que deve ser assinado
                XmlAttributeCollection uri = xmlDocAssinado.GetElementsByTagName(uriReferenciaAssinatura).Item(0).Attributes;
                foreach (XmlAttribute atributo in uri)
                {
                    if (atributo.Name == "Id")
                    {
                        reference.Uri = "#" + atributo.InnerText;
                    }
                }


                // Add an enveloped transformation to the reference.
                XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
                reference.AddTransform(env);

              

                XmlDsigC14NTransform c14 = new XmlDsigC14NTransform();
                reference.AddTransform(c14);

                // Add the reference to the SignedXml object.
                signedXml.AddReference(reference);

               
                // Create a new KeyInfo object
                KeyInfo keyInfo = new KeyInfo();

               
                // Load the certificate into a KeyInfoX509Data object
                // and add it to the KeyInfo object.
                keyInfo.AddClause(new KeyInfoX509Data(certificado));

                
                // Add the KeyInfo object to the SignedXml object.
                signedXml.KeyInfo = keyInfo;

              

                signedXml.ComputeSignature();

              


                // Get the XML representation of the signature and save it to an XmlElement object.
              
                xmlAssinatura = signedXml.GetXml();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao assinar o documento - " + ex.Message);
            }
            #endregion

            
            return xmlAssinatura;
        }
    }
}

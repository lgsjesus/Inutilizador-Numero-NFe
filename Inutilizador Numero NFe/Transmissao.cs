using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Inutilizador_Numero_NFe
{
    public class Transmissao
    {
        public XmlDocument TransmitirNFE(XmlDocument xmlSOAPEnvelope, X509Certificate2 certificado,
              string url, WebProxy proxy)
        {
            // Requisição
            XmlDocument xmlRetorno = new XmlDocument();

            try
            {

                ServicePointManager.ServerCertificateValidationCallback +=
                    new System.Net.Security.RemoteCertificateValidationCallback(CustomValidation);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.Timeout = Timeout.Infinite;
                request.ContentType = "application/soap+xml; charset=utf-8";
                byte[] dados = ASCIIEncoding.ASCII.GetBytes(xmlSOAPEnvelope.InnerXml);
                request.ContentLength = dados.Length;
                request.ClientCertificates.Add(certificado);
                request.KeepAlive = false;
                request.ServicePoint.Expect100Continue = false;
                request.Credentials = System.Net.CredentialCache.DefaultCredentials;


                // Proxy
                if (proxy != null)
                {
                    request.Proxy = proxy;
                }

                // Stream de comunicação
                Stream stream = request.GetRequestStream();
                stream.Write(dados, 0, dados.Length);
                stream.Flush();
                stream.Close();

                // Resposta
                WebResponse response = (WebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = "", line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    str = str + line;
                }
                xmlRetorno.LoadXml(str);
               // ProcessadorRegistros.qtdErrosConexao = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);           
            }

            return xmlRetorno;
        }
        public XmlDocument tentarConectar(XmlDocument xmlSOAPEnvelope, X509Certificate2 certificado,
           string url, WebProxy proxy)
        {
            // Requisição
            XmlDocument xmlRetorno = new XmlDocument();

            try
            {

                ServicePointManager.ServerCertificateValidationCallback +=
                    new System.Net.Security.RemoteCertificateValidationCallback(CustomValidation);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.Timeout = Timeout.Infinite;
                request.ContentType = "application/soap+xml; charset=utf-8";
                byte[] dados = ASCIIEncoding.ASCII.GetBytes(xmlSOAPEnvelope.InnerXml);
                request.ContentLength = dados.Length;
                request.ClientCertificates.Add(certificado);
                //  LogHelper.GravarLog(" Envio Completo  = " + xmlSOAPEnvelope.InnerXml);
                // Proxy
                if (proxy != null)
                {
                    request.Proxy = proxy;
                }

                // Stream de comunicação
                Stream stream = request.GetRequestStream();
                stream.Write(dados, 0, dados.Length);
                stream.Flush();
                stream.Close();

                // Resposta
                WebResponse response = (WebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = "", line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    str = str + line;
                }
                xmlRetorno.LoadXml(str);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return xmlRetorno;
        }
        private static bool CustomValidation(object sender, X509Certificate cert, X509Chain chain, System.Net.Security.SslPolicyErrors error)
        {
            return true;
        }
    }
}

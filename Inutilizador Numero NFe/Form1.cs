using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using static Inutilizador_Numero_NFe.leiauteInutNFe_v3_00;

namespace Inutilizador_Numero_NFe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textWS.Text = "https://nfe.sefazrs.rs.gov.br/ws/nfeinutilizacao/nfeinutilizacao2.asmx";
            textSerie.Text = "001";
            textCertificado.Text = "XXXXXXX";
            text1.Text = "1189";
            text2.Text = "1189";                             
            textCNPJ.Text = "XXXXXX";
            textJust.Text = "CADASTRADO A NOTA ERRADA E NAO USADA NA VENDA";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var certificado = CertificadoHelper.Consultar(StoreName.My, StoreLocation.CurrentUser, textCertificado.Text, TipoConsultaCertificado.PorNroSerie);
            if (certificado == null)
            {
                throw new Exception("Certificado Digital não encontrado! SERIALNUMBER= " + textCertificado.Text + ".");
            }

            string chave = "43" + DateTime.Now.ToString("yy") + textCNPJ.Text + "55" + textSerie.Text
               + text1.Text.PadLeft(9, '0') + text2.Text.PadLeft(9, '0');

            XmlDocument xmlConsSit = GerarXml("43",certificado);
            XmlDocument xmlSOAPConsSit = CriarEnvelopeInutNum(xmlConsSit, "43");

            //Salvar xml envio
            //ProcessadorRegistros.SalvarXML(xmlSOAPConsSit, Tipo_Servico_NFE.Solic_Inutilizacao, nfe_id, "inutilizacao_nfe", unid_data, filial, seq);

           Transmissao trans = new Transmissao();
            XmlDocument xmlRetorno = trans.TransmitirNFE(xmlSOAPConsSit, certificado, textWS.Text, null);

            ////Salvar xml retorno
            //ProcessadorRegistros.SalvarXML(xmlRetorno, Tipo_Servico_NFE.Solic_Inutilizacao, nfe_id, "ret_inutilizacao_nfe", unid_data, filial, seq);

            //ProcessarRetorno(filial, nfe_id, seq, xmlRetorno);
            xmlSOAPConsSit.Save("Inut_"+chave + ".xml");

            textResult.Text = xmlRetorno.InnerXml;

            xmlRetorno.Save("Ret_Inut_" + chave + ".xml");
        }

        private XmlDocument CriarEnvelopeInutNum(XmlDocument xml, string v)
        {
            if (SOAP_Envelopes.SOAP_Inut_Numeracao_v2_00.Count() == 0)
                throw new Exception("O envelope SOAP da Inutilização de Numerção não foi localizado");

            XmlDocument xmlEnvelope = new XmlDocument();

            xmlEnvelope.LoadXml(SOAP_Envelopes.SOAP_Inut_Numeracao_v2_00);

            //Configura o estado
            if (xmlEnvelope.GetElementsByTagName("cUF").Count > 0)
            {
                XmlNode nodeUF = xmlEnvelope.GetElementsByTagName("cUF")[0];
                nodeUF.InnerText = "43";
            }

            //Configura a versão
            if (xmlEnvelope.GetElementsByTagName("versaoDados").Count > 0)
            {
                XmlNode nodeUF = xmlEnvelope.GetElementsByTagName("versaoDados")[0];
                nodeUF.InnerText = "3.10";
            }

            //Adiciona a mensagem xml
            if (xmlEnvelope.GetElementsByTagName("nfeDadosMsg").Count > 0)
            {
                XmlNode xmlNfeDadosMsg = xmlEnvelope.GetElementsByTagName("nfeDadosMsg")[0];
                xml.RemoveChild(xml.FirstChild);
                xmlNfeDadosMsg.InnerXml = xml.InnerXml;
            }

            return xmlEnvelope;
        }

        private XmlDocument GerarXml(string v, X509Certificate2 certificado)
        {
           

            XmlDocument xmlInutNFe = new XmlDocument();
            xmlInutNFe.LoadXml(SOAP_Envelopes.NFE_Inutirilizacao);

            TInutNFe inutNFe = new TInutNFe();
            TInutNFeInfInut infInput = inutNFe.infInut = new TInutNFeInfInut();

            
            string cUF = string.Format("Item{0}", "43");
            infInput.cUF = (TCodUfIBGE)Enum.Parse(typeof(TCodUfIBGE), cUF);
            infInput.ano = DateTime.Now.ToString("yy");
            string chave = "43" + DateTime.Now.ToString("yy") + textCNPJ.Text + "55" + textSerie.Text
                + text1.Text.PadLeft(9, '0') + text2.Text.PadLeft(9, '0');

            //Identificador da TAG a ser assinada formada com 
            //Código da UF + Ano (2 posições) + CNPJ + modelo + série + nro inicial e nro final precedida do literal “ID”
            string id = string.Format("ID{0}", chave);
            infInput.Id = id;

            string cnpj = textCNPJ.Text;
            infInput.CNPJ = cnpj.PadLeft(14, '0'); //PadLeft é desnecessário, mas por segurança estou usando.

            string mod = string.Format("Item{0}", "55");
            infInput.mod = (TMod)Enum.Parse(typeof(TMod), mod);

            //infInput.mod = TMod.Item55;

            infInput.nNFFin = text2.Text;
            infInput.nNFIni = text1.Text;

            string serie = textSerie.Text;

            int serieNum = Convert.ToInt32(serie);
            infInput.serie = serieNum.ToString();

            string tpAmb = string.Format("Item{0}", "1");
            infInput.tpAmb = (TAmb)Enum.Parse(typeof(TAmb), tpAmb);


            infInput.xJust = textJust.Text;
            infInput.xServ = TInutNFeInfInutXServ.INUTILIZAR;
            XmlDocument xmlNFE = Serializacao.Serializar<TInutNFe>(inutNFe);

            XmlElement xmlAssinatura = AssinarXML.AssinarXmlNfe(xmlNFE, "infInut", certificado);
            XmlNode nodeInutNFe = xmlInutNFe.GetElementsByTagName("inutNFe")[0];
            if (nodeInutNFe != null)
            {
                nodeInutNFe.InnerXml = xmlNFE.GetElementsByTagName("infInut")[0].OuterXml;
                nodeInutNFe.InnerXml += xmlAssinatura.OuterXml;
            }

            return xmlInutNFe;
        }
    }
}

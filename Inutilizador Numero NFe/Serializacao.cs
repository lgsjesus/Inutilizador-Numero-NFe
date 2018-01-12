using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Inutilizador_Numero_NFe
{
    public class Serializacao
    {
        public static XmlDocument Serializar<T>(T envNFe, string uri = "http://www.portalfiscal.inf.br/nfe")
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            //Stream fileStream = new FileStream(fileName, FileMode.Create);
            Stream memoryStream = new MemoryStream();
            //Salva na condificação UTF-8
            StreamWriter streamWriter = new StreamWriter(memoryStream, Encoding.UTF8);

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", uri);

            serializer.Serialize(memoryStream, envNFe, ns);

            memoryStream.Position = 0;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(memoryStream);

            memoryStream.Close();

            return xmlDoc;

        }


        //public static XmlDocument SerializarNFE(ProdalyNFE.NFe.LeiauteNFE_v2_00.TEnviNFe envNFe)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(ProdalyNFE.NFe.LeiauteNFE_v2_00.TEnviNFe));

        //    //Stream fileStream = new FileStream(fileName, FileMode.Create);
        //    Stream memoryStream = new MemoryStream();
        //    //Salva na condificação UTF-8
        //    StreamWriter streamWriter = new StreamWriter(memoryStream, Encoding.UTF8);

        //    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
        //    ns.Add("", "http://www.portalfiscal.inf.br/nfe");

        //    serializer.Serialize(memoryStream, envNFe, ns);

        //    memoryStream.Position = 0;
        //    XmlDocument xmlDoc = new XmlDocument();
        //    xmlDoc.Load(memoryStream);

        //    memoryStream.Close();

        //    return xmlDoc;

        //}
    }
}

using Servidor.POJO;
using System.Xml.Serialization;
using System.IO;

namespace Servidor.Control
{
    public class Serializa
    {
        public Serializa()
        {

        }

        public string serializaTransaccion(Transaccion transaccion)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(Transaccion));
            StringWriter textWriter = new StringWriter();
            mySerializer.Serialize(textWriter, transaccion);
            return textWriter.ToString();
        }

        public Transaccion deSerializaTransaccion(string transaccionSerializada)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(Transaccion));
            TextReader reader = new StringReader(transaccionSerializada);
            return (Transaccion)mySerializer.Deserialize(reader); ;
        }
    }
}

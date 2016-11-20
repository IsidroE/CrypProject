using BankAplicationClient.POJO;
using System.Xml.Serialization;
using System.IO;

namespace BankAplicationClient.Control
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

        public string serializaLogin(LoginPOJO log)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(LoginPOJO));
            StringWriter textWriter = new StringWriter();
            mySerializer.Serialize(textWriter, log);
            return textWriter.ToString();
        }

        public LoginPOJO deSerializaLogin(string transaccionSerializada)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(LoginPOJO));
            TextReader reader = new StringReader(transaccionSerializada);
            return (LoginPOJO)mySerializer.Deserialize(reader); ;
        }

        public string serializaTransferenciaExterna(TransferenciaExterna transferenciaExterna)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(TransferenciaExterna));
            StringWriter textWriter = new StringWriter();
            mySerializer.Serialize(textWriter, transferenciaExterna);
            return textWriter.ToString();
        }

        public TransferenciaExterna deSerializaTransferenciaExterna(string transaccionSerializada)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(TransferenciaExterna));
            TextReader reader = new StringReader(transaccionSerializada);
            return (TransferenciaExterna)mySerializer.Deserialize(reader); ;
        }

        public string serializaCliente(Cliente cliente)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(Cliente));
            StringWriter textWriter = new StringWriter();
            mySerializer.Serialize(textWriter, cliente);
            return textWriter.ToString();
        }

        public Cliente deSerializaCliente(string transaccionSerializada)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(Cliente));
            TextReader reader = new StringReader(transaccionSerializada);
            return (Cliente)mySerializer.Deserialize(reader); ;
        }
    }
}

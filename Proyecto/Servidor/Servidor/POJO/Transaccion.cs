using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Servidor.POJO
{
    [Serializable]
    public class Transaccion
    {
        public byte[] objetoCifrado { get;  }
        public int Tipo { get; set; }

        public Transaccion()
        {}

        public Transaccion( int tipo, object objetoClaro, int llave ) //Ya veremos la llave...
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, objetoClaro);
            objetoCifrado = ms.ToArray();

            this.Tipo = tipo;
        }
    }
}

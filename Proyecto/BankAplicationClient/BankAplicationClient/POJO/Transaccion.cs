using System;

namespace BankAplicationClient.POJO
{
    [Serializable]
    public class Transaccion
    {
        object objeto = null;
        int tipo = 0;

        public Transaccion()
        {
        }

        public object Objeto
        {
            get
            {
                return objeto;
            }

            set
            {
                objeto = value;
            }
        }

        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
    }
}

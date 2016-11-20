using System;

namespace BankAplicationClient.POJO
{
    [Serializable]
    public class TransferenciaExterna
    {
        string nombres = null;
        string apellidoPaterno = null;
        string apellidoMaterno = null;
        int noCuenta = 0;
        int tipo = 0;

        public TransferenciaExterna()
        {
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }

            set
            {
                apellidoPaterno = value;
            }
        }

        public string ApellidoMaterno
        {
            get
            {
                return apellidoMaterno;
            }

            set
            {
                apellidoMaterno = value;
            }
        }

        public int NoCuenta
        {
            get
            {
                return noCuenta;
            }

            set
            {
                noCuenta = value;
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

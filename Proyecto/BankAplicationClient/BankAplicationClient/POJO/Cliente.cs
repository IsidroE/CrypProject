using System;

namespace BankAplicationClient.POJO
{
    [Serializable]
    public class Cliente
    {
        int idCliente = 0;
        string nombres = null;
        string apellidoPaterno = null;
        string apellidoMaterno = null;
        int noCuenta = 0;
        int noCuentaCredito = 0;
        string contrasenia = null;

        public Cliente()
        {
        }

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
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

        public int NoCuentaCredito
        {
            get
            {
                return noCuentaCredito;
            }

            set
            {
                noCuentaCredito = value;
            }
        }

        public string Contrasenia
        {
            get
            {
                return contrasenia;
            }

            set
            {
                contrasenia = value;
            }
        }

    }
}

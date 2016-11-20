using System;

namespace BankAplicationClient.POJO
{
    [Serializable]
    public class LoginPOJO
    {
        private string idCuenta;
        private string pasword;

        public LoginPOJO()
        {
        }

        public string IdCuenta
        {
            get
            {
                return idCuenta;
            }

            set
            {
                idCuenta = value;
            }
        }

        public string Pasword
        {
            get
            {
                return pasword;
            }

            set
            {
                pasword = value;
            }
        }
    }
}

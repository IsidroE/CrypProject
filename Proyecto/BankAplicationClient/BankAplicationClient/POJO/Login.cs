using System;

namespace BankAplicationClient.POJO
{
    public class Login
    {
        private int idCuenta;
        private string pasword;

        public void setIdCuenta(int idCuenta)
        {
            this.idCuenta = idCuenta;
        }
        public int getIdCuenta()
        {
            return idCuenta;
        }

        public void setPasword(string pasword)
        {
            this.pasword = pasword;
        }
        public string getPasword()
        {
            return pasword;
        }

        public String toString()
        {
            return "Login{" + "idCuenta=" + idCuenta + ", pasword=" + pasword + '}';
        }
    }
}

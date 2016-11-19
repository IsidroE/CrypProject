using System;

namespace BankAplicationClient.POJO
{
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

        public int getIdCliente()
        {
            return idCliente;
        }

        public void setIdCliente(int idCliente)
        {
            this.idCliente = idCliente;
        }

        public string getNombres()
        {
            return nombres;
        }

        public void setNombres(string nombres)
        {
            this.nombres = nombres;
        }

        public string getApellidoPaterno()
        {
            return apellidoPaterno;
        }

        public void setApellidoPaterno(string apellidoPaterno)
        {
            this.apellidoPaterno = apellidoPaterno;
        }

        public string getApellidoMaterno()
        {
            return apellidoMaterno;
        }

        public void setApellidoMaterno(string apellidoMaterno)
        {
            this.apellidoMaterno = apellidoMaterno;
        }

        public int getNoCuenta()
        {
            return noCuenta;
        }

        public void setNoCuenta(int noCuenta)
        {
            this.noCuenta = noCuenta;
        }

        public int getNoCuentaCredito()
        {
            return noCuentaCredito;
        }

        public void setNoCuentaCredito(int noCuentaCredito)
        {
            this.noCuentaCredito = noCuentaCredito;
        }

        public string getContrasenia()
        {
            return contrasenia;
        }

        public void setContrasenia(string contrasenia)
        {
            this.contrasenia = contrasenia;
        }

        public string toString()
        {
            return "Cliente{" + "idCliente=" + idCliente + ", nombres=" + nombres + ", apellidoPaterno=" + apellidoPaterno + ", apellidoMaterno=" + apellidoMaterno + ", noCuenta=" + noCuenta + ", noCuentaCredito=" + noCuentaCredito + ", contrasenia=" + contrasenia + '}';
        }

    }
}

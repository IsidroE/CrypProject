using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAplicationClient.POJO
{
    class TransferenciaExterna
    {
        string nombres = null;
        string apellidoPaterno = null;
        string apellidoMaterno = null;
        int noCuenta = 0;
        int tipo = 0;

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


        public int getTipo()
        {
            return noCuenta;
        }

        public void setTipo(int tipo)
        {
            this.tipo = tipo;
        }


    }
}

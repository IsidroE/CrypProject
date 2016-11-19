using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAplicationClient.POJO
{
    class Transaccion
    {
        object objeto = null;
        int tipo = 0 ;

        public object getObjeto()
        {
            return objeto;
        }

        public void setObjeto(object objeto)
        {
            this.objeto = objeto;
        }

        public int getTipo()
        {
            return tipo;
        }

        public void setTipo(int tipo)
        {
            this.tipo = tipo;
        }

        public String toString()
        {
            return "Cliente{" + "objeto=" + objeto + ", tipo=" + tipo + '}';
        }

    }
}

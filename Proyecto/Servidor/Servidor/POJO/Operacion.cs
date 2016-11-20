using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.POJO
{
    public class Operacion
    {
        public const int ERROR = 0;
        public const int EXITO = 1;
        public const int LOGIN = 2;
        public const int CONSULTA_AHORRO = 3;
        public const int CONSULTA_CREDITO = 4;
        public const int CONSULTA_MOVIMIENTOS_GENERALES = 5;
        public const int CONSULTA_MOVIMIENTOS_AHORRO = 6;
        public const int CONSULTA_MOVIMIENTOS_CREDITO = 7;
        public const int TRANFERENCIA_INTERNA = 8;
        public const int TRANFERENCIA_EXTERNA = 9;
    }
}

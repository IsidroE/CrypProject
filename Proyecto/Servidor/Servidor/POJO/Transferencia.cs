using System;

namespace Servidor.POJO
{
    [Serializable]
    public class Transferencia
    {
        public Cuenta origen { get; }
        public Cuenta destino { get;  }
        public double monto { get; }
        // Falso - Ahorros hacia crédito
        // Verdadero - crédito hacia ahorros

        public Transferencia()
        {}

        public Transferencia(Cuenta ori, Cuenta dest, double mon)
        {
            origen = ori;
            destino = dest;
            monto = mon;
        }
    }
}


using System;

namespace Servidor.POJO
{
    [Serializable]
    public class Movimiento
    {
        public int idMovimiento { get; }
        public Cuenta dueno { get; }
        public int otraCuenta { get; } // Guarda el origen o destino de una transaccion, para otros movimientos es nulo
        public DateTime fecha { get; }
        public double monto { get; }
        public string descripcion { get; set; }
        public int tipo { get; }
        // 0 - Transferencia externa enviada
        // 1 - Transferencia externa recibida
        // 2 - Transferencia interna
        // 3 - Pago
        // 4 - Cargo
        // 5 - Depósito
        // 6 - Retiro

        public Movimiento()
        {}

        public Movimiento(int idMovimiento, Cuenta dueno, int otraCuenta, DateTime fecha, double monto, int tipo)
        {
            this.idMovimiento = idMovimiento;
            this.dueno = dueno;
            this.otraCuenta = otraCuenta;
            this.fecha = fecha;
            this.monto = monto;
            this.tipo = tipo;
        }
    }
}

using System;

namespace Servidor.POJO
{
    [Serializable]
    public class Cuenta
    {
        public int idCuenta { get; }
        public Usuario dueno { get; }
        public double balance { get; }
        public double credit { get; }
        public int tipo { get; }
        // 1 - Crédito
        // 2 - Ahorros

        public Cuenta()
        { }

        public Cuenta(int idCuenta, Usuario dueno, int tipo, double balance, double credit)
        {
            this.idCuenta = idCuenta;
            this.dueno = dueno;
            this.tipo = tipo;
            this.balance = balance;
            this.credit = credit;
        }
    }
}

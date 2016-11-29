using System;

namespace Servidor.POJO
{
    [Serializable]
    public class Usuario
    {
        public int idCliente { get; }
        public string userName { get; }
        public byte[] password { get; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }

        public Usuario()
        {}

        public Usuario(int idCliente, string usr, byte[] pass)
        {
            this.idCliente = idCliente;
            userName = usr;
            password = pass;
        }

        public Usuario(int idCliente, string usr)
        {
            this.idCliente = idCliente;
            userName = usr;
        }
    }
}

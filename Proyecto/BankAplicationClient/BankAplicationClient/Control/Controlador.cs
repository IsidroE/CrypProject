using BankAplicationClient.POJO;

namespace BankAplicationClient.Control
{
    public class Controlador
    {
        SocketCliente socketCliente = new SocketCliente();
        Cliente cliente = new Cliente();
        Serializa serializa = new Serializa();
        CifradoAES aes = new CifradoAES();

        public Controlador()
        {
        }
        internal bool login(LoginPOJO log)
        {
            bool bandera = false;
            //Genera la transaccion a enviar
            Transaccion transaccion = new Transaccion();
            //por alguna razon no puedo serializar un pojo que adentro tien otro pojo
            // la verdad no supe solucionar este problema mas que serializar el pojo login
            //y despues mandarlo serializado
            //lo mismo para enviar otras POJOS
            transaccion.Objeto = (object)serializa.serializaLogin(log);
            transaccion.Tipo = Operacion.LOGIN;
            //envia transaccion
            if(enviaTransaccion(transaccion))
            {
                bandera = true;
            }
            return bandera;
        }

        internal bool ConsultaSaldo(int tipo)
        {
            bool bandera = false;
            //Genera la transaccion a enviar
            Transaccion transaccion = new Transaccion();
            transaccion.Objeto = (object) serializa.serializaCliente(cliente);
            transaccion.Tipo = tipo;
            //envia transaccion
            if (enviaTransaccion(transaccion))
            {
                bandera = true;
            }
            return bandera;
        }

        internal bool transferir(TransferenciaExterna te)
        {
            bool bandera = false;
            //Genera la transaccion a enviar
            Transaccion transaccion = new Transaccion();
            transaccion.Objeto = (object)serializa.serializaTransferenciaExterna(te);
            transaccion.Tipo = Operacion.TRANFERENCIA_EXTERNA;
            //envia transaccion
            if (enviaTransaccion(transaccion))
            {
                bandera = true;
            }
            return bandera;
        }

        private bool enviaTransaccion(Transaccion transaccion)
        {
            bool bandera = false;
            //serializa la transaccion
            string transaccionSerializada = serializa.serializaTransaccion(transaccion);
            //cifra la transaccion 
            string transaccionSerializadaCifrada = aes.cifrar(transaccionSerializada);
            //envia la trasaccion al servidor
            socketCliente.Send(transaccionSerializadaCifrada);
            //recibe respuesta de servidor
            string respuesta = socketCliente.Receive();
            if (respuesta != null)
            {
                //descifra la respuesta
                string respuestaDescifrada = aes.descifrar(respuesta);
                //Evalua si fue exitosa la trasaccion
                transaccion = serializa.deSerializaTransaccion(respuestaDescifrada);
                if (transaccion.Tipo == Operacion.EXITO)
                {
                    bandera = true;
                }
            }
            return bandera;
        }

        internal Cliente getUsuario()
        {
            return cliente;
        }

        internal void salir()
        {
            socketCliente.closeSocket();
        }
    }
}

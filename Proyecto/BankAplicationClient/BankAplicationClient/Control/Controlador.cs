using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAplicationClient.POJO;

namespace BankAplicationClient.Control
{
    public class Controlador
    {
        SocketCliente socketCliente = new SocketCliente();

        Cliente cliente = new Cliente();

        public Controlador()
        {
            
        }
        internal bool login(string idCuenta, string pasword)
        {
            bool bandera = false;
            socketCliente.Send("Quiero ingresar con este Id:"+idCuenta + "y este pasword: "+ pasword);
            bandera = true;
            return bandera;
        }

        internal bool ConsultaSaldo()
        {
            bool bandera = false;
            socketCliente.Send( "Quiero consultar mi saldo");
            //Borrar la siguiente instruccion
            bandera = true;

            return bandera;
        }

        internal Cliente getUsuario()
        {
            return cliente;
        }

        internal bool transferir(TransferenciaExterna te)
        {
            bool bandera = false;


            //Borrar la siguiente instruccion
            bandera = true;

            return bandera;
        }

        internal void salir()
        {
            socketCliente.closeSocket();
        }
    }
}

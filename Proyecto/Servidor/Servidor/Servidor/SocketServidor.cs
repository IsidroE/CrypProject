using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Servidor.Servidor
{
    public class SocketServidor
    {
        private readonly Socket socket_Servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private readonly List<Socket> Sockets_clientes = new List<Socket>();
        private const int BUFFER_SIZE = 2048; 
        private const int PORT = 11000;
        private readonly byte[] buffer = new byte[BUFFER_SIZE];

        //Constructor
        public SocketServidor()
        {
            iniciarServidor();
            Console.ReadLine(); /*cierra el servidor al presionar cualquie tecla*/
            CloseAllSockets();
        }

        //Inicia el servidor
        private void iniciarServidor()
        {
            Console.WriteLine("Iniciando servidor...");
            socket_Servidor.Bind(new IPEndPoint(IPAddress.Any, PORT));
            socket_Servidor.Listen(0);
            socket_Servidor.BeginAccept(AcceptCallback, null);
            Console.WriteLine("servidor iniciado...");
        }

        //Cierra todos los sockets   
        private void CloseAllSockets()
        {
            foreach (Socket socket in Sockets_clientes)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            socket_Servidor.Close();
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;
            try
            {
                socket = socket_Servidor.EndAccept(AR);
            }
            catch (ObjectDisposedException) { return; }
            //Agrega un nuevo socket a la lista
            Sockets_clientes.Add(socket);
            socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
            Console.WriteLine("Cliente conectado...");
            socket_Servidor.BeginAccept(AcceptCallback, null);
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;
            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                Console.WriteLine("Cliente desconectado inesperadamente");
                current.Close();
                Sockets_clientes.Remove(current);
                return;
            }
            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            Console.WriteLine("Llego: " + text);


            // aqui se implementaran las funciones nesesarias para operar
            // cuando llegue algo en el string text se descifrara
            // si es primera conexion generara las llaves
            if (text.ToLower() == "exit") // El Cliente cerro sesion
            {
                // Always Shutdown before closing
                current.Shutdown(SocketShutdown.Both);
                current.Close();
                Sockets_clientes.Remove(current);
                Console.WriteLine("Client disconnected");
                return;
            }
            byte[] data = Encoding.ASCII.GetBytes("Recibi tu peticion......");
            current.Send(data);
            Console.WriteLine("Esperando cliente");

            current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
        }

    }
}

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BankAplicationClient.Control
{
    public class SocketCliente
    {

        private readonly Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private const int PORT = 11000;

        //Constructor
        public SocketCliente()
        {
            ConnectToServer();
        }

        //Inicia el socket y conecta con el servidor
        private void ConnectToServer()
        {
            try
            {
                Console.WriteLine("Intentando conectar con el servidor ");
                // Change IPAddress.Loopback to a remote IP to connect to a remote host.
                ClientSocket.Connect(IPAddress.Loopback, PORT);
            }
            catch (SocketException)
            {
                Console.Clear();
            }
            Console.WriteLine("Cliente conectado con el servidor");
        }

        //Cierra el socket Cliente
        public void closeSocket()
        {
            //Anuncia al servidor que se desconectara.
            Send("exit");
            ClientSocket.Shutdown(SocketShutdown.Both);
            ClientSocket.Close();
            Environment.Exit(0);
        }

        public void Send(string text)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        public string Receive()
        {
            var buffer = new byte[2048];
            int received = ClientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return null;
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            string text = Encoding.ASCII.GetString(data);
            return text;
        }
    }
}

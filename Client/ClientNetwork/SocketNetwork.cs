using Client.Controller;
using System;
using System.Net.Sockets;
using System.Text;

namespace Client.Network
{
    public class SocketNetwork : INetwork, IDisposable
    {
        private readonly string serverIp = "127.0.0.1";
        private readonly int port = 13000;

        private TcpClient tcpClient;
        private NetworkStream networkStream;

        public void Send(string type, string function, string data)
        {
            byte[] message = Encoding.ASCII.GetBytes($"{type};{function};{data}");

            networkStream.Write(message, 0, message.Length);
        }

        public string Receive()
        {
            byte[] data = new byte[256];

            int bytesRead = networkStream.Read(data, 0, data.Length);

            return Encoding.ASCII.GetString(data, 0, bytesRead);
        }

        public void Connect()
        {
            tcpClient = new TcpClient(serverIp, port);
            networkStream = tcpClient.GetStream();
        }

        public void Disconnect()
        {
            byte[] message = Encoding.ASCII.GetBytes("Disconnect");
            networkStream.Write(message, 0, message.Length);

            networkStream.Close();
            tcpClient.Close();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                networkStream.Dispose();
                tcpClient.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

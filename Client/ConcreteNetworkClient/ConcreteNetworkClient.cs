using System;
using System.Net.Sockets;
using System.Text;

namespace TcpIp_Extended
{
    public class ConcreteNetworkClient : IConcreteNetworkClient, IDisposable
    {
        private readonly string serverIp = "127.0.0.1";
        private readonly int port = 13000;

        private TcpClient tcpClient;
        private NetworkStream networkStream;

        public void Send(string type, string function, string message)
        {
            Connect();

            byte[] data = Encoding.ASCII.GetBytes($"{type};{function};{message}");

            networkStream.Write(data, 0, data.Length);
        }

        public string Receive()
        {
            byte[] data = new byte[256];

            int bytesRead = networkStream.Read(data, 0, data.Length);

            Disconnect();

            return Encoding.ASCII.GetString(data, 0, bytesRead);
        }

        private void Connect()
        {
            tcpClient = new TcpClient(serverIp, port);
            networkStream = tcpClient.GetStream();
        }

        private void Disconnect()
        {
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

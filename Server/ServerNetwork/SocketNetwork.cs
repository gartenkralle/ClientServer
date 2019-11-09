using System;
using System.Net;
using System.Net.Sockets;
using Server.Controller;

namespace Server.Network
{
    public class SocketNetwork : INetwork, IDisposable
    {
        private readonly int port = 13000;
        private readonly string serverIp = "127.0.0.1";

        private readonly byte[] bytes;
        private readonly TcpListener tcpListener;
        private TcpClient tcpClient;
        private NetworkStream networkStream;

        public SocketNetwork()
        {
            IPAddress localAddr = IPAddress.Parse(serverIp);

            tcpListener = new TcpListener(localAddr, port);
            tcpListener.Start();

            bytes = new byte[256];
        }

        public string Receive()
        {
            int bytesRead = networkStream.Read(bytes, 0, bytes.Length);

            return System.Text.Encoding.ASCII.GetString(bytes, 0, bytesRead);
        }

        public void Send(string data)
        {
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
            networkStream.Write(msg, 0, msg.Length);
        }

        public void Connect()
        {
            tcpClient = tcpListener.AcceptTcpClient();
            networkStream = tcpClient.GetStream();
        }

        public void Disconnect()
        {
            tcpClient.Close();
            networkStream.Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                tcpClient.Close();
                tcpListener.Stop();
                networkStream.Dispose();
            }
        }
    }
}

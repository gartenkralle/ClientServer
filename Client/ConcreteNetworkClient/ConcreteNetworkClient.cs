﻿using System;
using System.Net.Sockets;

namespace TcpIp_Extended
{
    public class ConcreteNetworkClient : IConcreteNetworkClient, IDisposable
    {
        private readonly string serverIp = "127.0.0.1";
        private readonly int port = 13000;

        private readonly TcpClient tcpClient;
        private readonly NetworkStream networkStream;

        public ConcreteNetworkClient()
        {
            tcpClient = new TcpClient(serverIp, port);
            networkStream = tcpClient.GetStream();
        }

        public void Send(string type, string function, string message)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes($"{type};{function};{message}");

            networkStream.Write(data, 0, data.Length);
        }

        public string Receive()
        {
            byte[] data = new byte[256];

            int bytesRead;

            bytesRead = networkStream.Read(data, 0, data.Length);

            return System.Text.Encoding.ASCII.GetString(data, 0, bytesRead);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                networkStream.Close();
                networkStream.Dispose();
                tcpClient.Close();
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

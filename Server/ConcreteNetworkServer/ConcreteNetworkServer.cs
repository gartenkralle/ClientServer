﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using TcpIp_Extended;

namespace TcpIp_Server
{
    public class ConcreteNetworkServer : IConcreteNetworkServer, IDisposable
    {
        private readonly int port = 13000;
        private readonly string serverIp = "127.0.0.1";

        private readonly byte[] bytes;
        private string data;

        private readonly TcpListener tcpListener;
        private TcpClient tcpClient;
        private NetworkStream networkStream;

        public bool IsClientConnected => tcpClient.Connected;

        public ConcreteNetworkServer()
        {
            IPAddress localAddr = IPAddress.Parse(serverIp);

            tcpListener = new TcpListener(localAddr, port);
            tcpListener.Start();

            bytes = new byte[256];

            Open();
        }

        public string Receive()
        {
            while(!networkStream.DataAvailable)
            {
                Thread.Sleep(200);
            }

            data = null;

            int bytesRead;

            bytesRead = networkStream.Read(bytes, 0, bytes.Length);

            data = System.Text.Encoding.ASCII.GetString(bytes, 0, bytesRead);
            Console.WriteLine("Received: {0}", data);

            return data;
        }

        public void Send(string data)
        {
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

            networkStream.Write(msg, 0, msg.Length);
            Console.WriteLine("Sent: {0}", data);
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
                Close();
            }
        }

        private void Open()
        {
            Console.WriteLine("Waiting for a connection... ");

            tcpClient = tcpListener.AcceptTcpClient();

            Console.WriteLine("Connected!");

            networkStream = tcpClient.GetStream();
        }

        private void Close()
        {
            tcpClient.Close();
            networkStream.Dispose();
            Console.WriteLine("Disconnected!");
        }
    }
}

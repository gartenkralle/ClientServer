using System;
using System.Net;
using System.Net.Sockets;
using TcpIp_Extended;

namespace TcpIp_Server
{
    public class ConcreteNetworkServer : IConcreteNetworkServer
    {
        private readonly int port = 13000;
        private readonly string serverIp = "127.0.0.1";

        byte[] bytes;
        string data;

        TcpListener server;
        TcpClient client;
        NetworkStream stream;

        public ConcreteNetworkServer()
        {
            IPAddress localAddr = IPAddress.Parse(serverIp);

            server = new TcpListener(localAddr, port);
            server.Start();

            bytes = new byte[256];
        }

        public void Accept()
        {
            Console.WriteLine("Waiting for a connection... ");

            client = server.AcceptTcpClient();

            Console.WriteLine("Connected!");
        }

        public string Receive()
        {
            data = null;

            stream = client.GetStream();

            int bytesRead;


            bytesRead = stream.Read(bytes, 0, bytes.Length);

            data = System.Text.Encoding.ASCII.GetString(bytes, 0, bytesRead);
            Console.WriteLine("Received: {0}", data);

            client.Close();
            Console.WriteLine("Disconnected!");

            return data;
        }

        public void Send(string type, string function, string data)
        {
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

            stream.Write(msg, 0, msg.Length);
            Console.WriteLine("Sent: {0}", data);
        }
    }
}

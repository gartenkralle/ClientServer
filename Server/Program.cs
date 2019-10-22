using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using TcpServer;

namespace TcpIp_Extended
{
    class ServerProgram
    {
        public static void Main()
        {
            TcpListener server = null;

            try
            {
                int port = 13000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                server = new TcpListener(localAddr, port);

                server.Start();

                byte[] bytes = new byte[256];
                string data = null;

                while (true)
                {
                    Console.WriteLine("Waiting for a connection... ");

                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    data = null;

                    NetworkStream stream = client.GetStream();

                    int bytesRead;

                    try
                    {
                        while ((bytesRead = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, bytesRead);
                            Console.WriteLine("Received: {0}", data);

                            Request request = new Request(data);
                            data = new Respone(request).getResult();

                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                            stream.Write(msg, 0, msg.Length);
                            Console.WriteLine("Sent: {0}", data);
                        }
                    }
                    catch (IOException)
                    {
                        continue;
                    }
                    finally
                    {
                        client.Close();
                        Console.WriteLine("Disconnected!");
                    }
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                server.Stop();
            }
        }
    }
}
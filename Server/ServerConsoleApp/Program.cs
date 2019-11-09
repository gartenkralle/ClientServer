using Server.Controller;
using Server.Dispatchment;
using Server.Factory;
using Server.Network;
using System;

namespace Server.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            INetwork network = new SocketNetwork();
            NetworkController networkController = new NetworkController(network);
            Dispatcher dispatcher = new Dispatcher(new ControllerFactory(new CollectionFactory()), new ModelFactory());

            bool connected = false;

            while (true)
            {
                if(!connected)
                {
                    Console.WriteLine("Waiting for a connection... ");
                    network.Connect();
                    Console.WriteLine("Connected!");
                    connected = true;
                }

                string request = networkController.Receive();
                Console.WriteLine("Received: {0}", request);

                if (request == "Disconnect")
                {
                    network.Disconnect();
                    Console.WriteLine("Disconnected!");
                    connected = false;
                    continue;
                }

                string response = dispatcher.Dispatch(request);

                networkController.Send(response);
                Console.WriteLine("Sent: {0}", response);
            }
        }
    }
}
using Server.Controller;
using Server.Dispatchment;
using Server.Factory;
using Server.Network;

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
                    network.Connect();
                    connected = true;
                }

                string request = networkController.Receive();

                if (request == "Disconnect")
                {
                    network.Disconnect();
                    connected = false;
                    continue;
                }

                string response = dispatcher.Dispatch(request);

                networkController.Send(response);
            }
        }
    }
}
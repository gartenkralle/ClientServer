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
            NetworkController networkController = new NetworkController(new SocketNetwork());
            Dispatcher dispatcher = new Dispatcher(new ControllerFactory(new CollectionFactory()), new ModelFactory());

            while (true)
            {
                string request = networkController.Receive();

                string response = dispatcher.Dispatch(request);

                networkController.Send(response);
            }
        }
    }
}
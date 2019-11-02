using Dispatchment;
using ServerModel;
using TcpIp_Server;

namespace Server
{
    class ServerProgram
    {
        static void Main()
        {
            NetworkServerController networkServerController = new NetworkServerController(new SocketNetworkServer());
            Dispatcher dispatcher = new Dispatcher(new ServerControllerFactory(new DataEntityModelFactory()), new DataEntityFactory());

            while (true)
            {
                string request = networkServerController.Receive();

                string response = dispatcher.Dispatch(request);

                networkServerController.Send(response);
            }
        }
    }
}
using TcpIp_Server;

namespace Server
{
    class ServerProgram
    {
        static void Main()
        {
            NetworkServerController networkServerController = new NetworkServerController(new SocketNetworkServer());

            while (true)
            {
                string request = networkServerController.Receive();

                string response = NetworkServerController.Dispatch(request);

                networkServerController.Send(response);
            }
        }
    }
}
using DataTypes;
using TcpIp_Server;
using TcpServer;

namespace Server
{
    class ServerProgram
    {
        static void Main()
        {
            NetworkServerController networkServerController = new NetworkServerController(new NetworkServer(new SocketNetworkServer()));

            while (true)
            {
                string request = networkServerController.Receive();

                string response = networkServerController.Dispatch(request);

                networkServerController.Send(response);
            }
        }
    }
}
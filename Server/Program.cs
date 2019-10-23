using NetworkServerController;
using TcpIp_Server;

namespace TcpIp_Extended
{
    class ServerProgram
    {
        static void Main()
        {
            NetworkController networkController = new NetworkController(new NetworkServer(new ConcreteNetworkServer()));
        }
    }
}
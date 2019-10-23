using System;
using TcpIp_Extended;

namespace ConcreteNetworkServer
{
    public class ConcreteNetworkServer : IConcreteNetworkServer
    {
        public string Receive()
        {
            throw new NotImplementedException();
        }

        public void Send(string type, string function, string data)
        {
            throw new NotImplementedException();
        }
    }
}

using System;

namespace TcpIp_Extended
{
    public interface IConcreteNetworkServer
    {
        void Send(string data);

        string Receive();
    }
}

using System;

namespace TcpIp_Extended
{
    public interface IConcreteNetworkClient : IDisposable
    {
        void Send(string type, string function, string data);
        string Receive();
    }
}

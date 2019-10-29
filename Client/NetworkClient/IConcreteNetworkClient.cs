using System;

namespace TcpIp_Extended
{
    public interface IConcreteNetworkClient : IDisposable
    {
        void Send(string message);
        string Receive();
    }
}

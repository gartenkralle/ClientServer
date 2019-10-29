using DataTypes;
using System;

namespace TcpIp_Extended
{
    public interface INetworkServer
    {
        string Receive();
        void Send(string data);
    }
}

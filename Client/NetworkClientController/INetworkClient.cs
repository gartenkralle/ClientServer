namespace TcpIp_Extended
{
    public interface INetworkClient
    {
        void Send(string type, string function, string data);
        string Receive();
    }
}

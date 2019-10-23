namespace TcpIp_Extended
{
    public interface IConcreteNetworkClient
    {
        void Send(string type, string function, string data);

        string Receive();
    }
}

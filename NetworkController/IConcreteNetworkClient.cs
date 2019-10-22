namespace TcpIp_Extended
{
    public interface IConcreteNetworkClient
    {
        void Send(string type, string data);

        string Receive();
    }
}

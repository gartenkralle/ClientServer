namespace TcpIp_Extended
{
    public interface IConcreteNetworkServer
    {
        void Accept();

        void Send(string type, string function, string data);

        string Receive();
    }
}

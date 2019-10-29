namespace TcpIp_Extended
{
    public interface IConcreteNetworkServer
    {
        string Receive();

        void Send(string data);        
    }
}

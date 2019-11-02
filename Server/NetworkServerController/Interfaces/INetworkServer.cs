namespace ServerController
{
    public interface INetworkServer
    {
        string Receive();
        void Send(string data);
    }
}

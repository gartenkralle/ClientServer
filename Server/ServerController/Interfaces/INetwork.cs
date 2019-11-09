namespace Server.Controller
{
    public interface INetwork
    {
        void Connect();
        void Disconnect();
        string Receive();
        void Send(string data);
    }
}

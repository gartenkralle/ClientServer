namespace Client.Controller
{
    public interface INetwork
    {
        void Connect();
        void Disconnect();
        void Send(string type, string function, string data);
        string Receive();
    }
}

namespace Client.Controller
{
    public interface INetwork
    {
        void Send(string type, string function, string data);
        string Receive();
    }
}

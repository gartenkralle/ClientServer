namespace Server.Controller
{
    public interface INetwork
    {
        string Receive();
        void Send(string data);
    }
}

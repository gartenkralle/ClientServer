namespace Server.Controller
{
    public class NetworkController
    {
        private readonly INetwork networkServer;

        public NetworkController(INetwork networkServer)
        {
            this.networkServer = networkServer;
        }

        public string Receive()
        {
            return networkServer.Receive();
        }

        public void Send(string data)
        {
            networkServer.Send(data);
        }
    }
}

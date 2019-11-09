namespace Server.Dispatchment
{
    internal class Request
    {
        internal Request(string message)
        {
            string[] arr = message.Split(';');

            Type = arr[0];
            Function = arr[1];
            Data = arr[2];
        }

        internal string Type { get; }

        internal string Function { get; }

        internal string Data { get; }
    }
}

using System;
using TcpServer;

namespace TcpIp_Extended
{
    internal class Respone
    {
        private readonly Request request;

        internal Respone(Request request)
        {
            this.request = request;
        }

        internal string getResult()
        {
            return "true";
        }
    }
}
using DataTypes;
using System;
using TcpServer;

namespace TcpIp_Extended
{
    internal class Respone
    {
        private readonly Request request;

        internal Respone(Request request)
        {
            if(request.Type == nameof(Employee))
            this.request = request;
        }

        internal string getResult()
        {
            return "true";
        }
    }
}
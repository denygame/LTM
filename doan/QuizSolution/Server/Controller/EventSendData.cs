using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controller
{
    public class EventSendData
    {
        private string ip;
        private string port;

        public string Ip { get => ip; set => ip = value; }
        public string Port { get => port; set => port = value; }

        public EventSendData(string ip, string port)
        {
            this.Ip = ip;
            this.Port = port;
        }
    }
}

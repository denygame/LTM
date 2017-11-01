using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controller
{
    public class Ip
    {
        public static string getIpLocal()
        {
            string myIP = "";
            string hostname = "";
            IPHostEntry ip = new IPHostEntry();
            hostname = Dns.GetHostName();
            ip = Dns.GetHostByName(hostname);

            foreach (IPAddress listip in ip.AddressList)
            {
                myIP = listip.ToString();
            }
            return myIP;
        }
    }
}

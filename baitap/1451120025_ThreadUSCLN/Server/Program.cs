using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== USCLN Thread ===");
            Socket sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sckServer.Bind(new IPEndPoint(IPAddress.Any, 12345));
            sckServer.Listen(10);
            Console.WriteLine("Waiting.......");
            while (true)
            {
                Socket sckClient = sckServer.Accept();
                ConnectionHandle conn = new ConnectionHandle(sckClient);
                (new Thread(conn.run)).Start();
            }
        }
    }
}

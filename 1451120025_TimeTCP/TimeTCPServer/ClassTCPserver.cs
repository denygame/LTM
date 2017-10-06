using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TimeTCPServer
{
    public class ClassTCPserver
    {
        public static Socket getSocketServer(int port)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, port);
            Socket sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sckServer.Bind(ipep);
            sckServer.Listen(5);
            return sckServer;
        }

        public static Socket getClient(Socket sckServer)
        {
            Console.WriteLine("Dang cho ket noi tu client....");
            Socket sckClient = sckServer.Accept();
            Console.WriteLine("Ket noi tu: " + sckClient.RemoteEndPoint);
            return sckClient;
        }

        public static void sendData(byte[] data, Socket sckClient)
        {
            sckClient.Send(data);
        }

        public static string receiveString(Socket sckClient)
        {
            var data = new byte[1024];
            int size = sckClient.Receive(data);
            return Encoding.ASCII.GetString(data, 0, size);
        }
    }
}

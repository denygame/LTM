using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TimeTCPClient
{
    public class ClassTCPclient
    {
        public static Socket connectToServer(string ip, int port)
        {
            Console.WriteLine("--------------TCP Client--------------");
            Socket sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);
            sckClient.Connect(ipep);
            Console.WriteLine("Ket noi den server thanh cong!");
            return sckClient;
        }

        public static string receiveString(Socket sckClient)
        {
            var data = new byte[1024];
            int size = sckClient.Receive(data);
            return Encoding.ASCII.GetString(data, 0, size);
        }

        public static void send(byte[] data, Socket sckClient)
        {
            sckClient.Send(data);
        }
    }
}

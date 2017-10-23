using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerUdp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Thanh Huy - 1451120025");
            Console.WriteLine("------------UDP Server-----------\r\n");
            Socket sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint localEp = new IPEndPoint(IPAddress.Any, 12345);
            sckServer.Bind(localEp);

            byte[] data = new byte[1024];
            EndPoint clientEp = new IPEndPoint(IPAddress.Any, 0);

            eachClient://nhan lan luot phuc vu client
            Console.WriteLine("\r\n Dang cho client ket noi........\r\n");

            int size = sckServer.ReceiveFrom(data, ref clientEp);
            Console.WriteLine("Nhan yeu cau tu client " + clientEp.ToString());

            while (true)
            {
                size = sckServer.ReceiveFrom(data, ref clientEp);//chức năng
                int type = int.Parse(Encoding.ASCII.GetString(data, 0, size));
                size = sckServer.ReceiveFrom(data, ref clientEp);//chuoi S
                string strS = Encoding.ASCII.GetString(data, 0, size);
                size = sckServer.ReceiveFrom(data, ref clientEp);//so N
                int n = int.Parse(Encoding.ASCII.GetString(data, 0, size));

                string result = SimpleEnCode.solution(type, strS, n);
                sckServer.SendTo(Encoding.ASCII.GetBytes("Ket qua la: " + result), clientEp);

                size = sckServer.ReceiveFrom(data, ref clientEp);
                string strLoop = Encoding.ASCII.GetString(data, 0, size);
                if (strLoop == "k") goto eachClient;
            }

        }
    }
}

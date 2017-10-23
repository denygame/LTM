using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientUdp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1451120025 - Nguyen Thanh Huy\r\n");
            Console.WriteLine("---UDP Time Client---");
            Socket sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            try
            {
                EndPoint serverEp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 22333);
                sckClient.SendTo(Encoding.ASCII.GetBytes("HELLO"), serverEp);
                byte[] data = new byte[1024];

                while (true)
                {
                    Console.Write("Nhap duong dan: ");
                    string request = Console.ReadLine();
                    sckClient.SendTo(Encoding.ASCII.GetBytes(request), serverEp);
                    int size = sckClient.ReceiveFrom(data, ref serverEp);
                    Console.WriteLine(Encoding.ASCII.GetString(data, 0, size));
                }
            }
            catch
            {
                Console.ReadKey();
            }
        }
    }
}

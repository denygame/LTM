using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Thanh Huy - 1451120025");
            Console.WriteLine("------------------ UDP Server ------------------\r\n");
            Socket sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint localEp = new IPEndPoint(IPAddress.Any, 9999);
            sckServer.Bind(localEp);
            Console.WriteLine("Dang cho ket noi......");


            int size = 0;
            var buff = new byte[1024];
            EndPoint clientEp = new IPEndPoint(IPAddress.Any, 0);

            size = sckServer.ReceiveFrom(buff, ref clientEp);
            Console.WriteLine("Ket noi tu: " + clientEp.ToString());

            size = sckServer.ReceiveFrom(buff, ref clientEp);

            string recv = Encoding.ASCII.GetString(buff, 0, size);
            var listNum = recv.Split(';');
            float num1 = float.Parse(listNum[0]);
            float num2 = float.Parse(listNum[1]);

            sckServer.SendTo(Encoding.ASCII.GetBytes((num1 + num2) + ";" + (num1 - num2) + ";" + (num1 * num2) + ";" + (num1 / num2)), clientEp);

            sckServer.Close();
            Console.ReadKey();
        }
    }
}

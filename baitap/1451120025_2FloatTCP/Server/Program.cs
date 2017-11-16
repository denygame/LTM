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
            Console.WriteLine("-------------- TCP Server --------------\r\n");
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9999);
            Socket sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sckServer.Bind(ipep);
            sckServer.Listen(10);

            Console.WriteLine("Dang cho ket noi.....");
            Socket sckAccept = sckServer.Accept();
            Console.WriteLine("Ket noi tu: " + sckAccept.RemoteEndPoint);

            var data = new byte[1024];
            int size = sckAccept.Receive(data);
            string recv = Encoding.ASCII.GetString(data, 0, size);
            var listNum = recv.Split(';');
            float num1 = float.Parse(listNum[0]);
            float num2 = float.Parse(listNum[1]);

            sckAccept.Send(Encoding.ASCII.GetBytes((num1 + num2) + ";" + (num1 - num2) + ";" + (num1 * num2) + ";" + (num1 / num2)));

            Console.WriteLine("\r\nKet Thuc!");
            sckAccept.Close();
            sckServer.Close();
            Console.ReadKey();
        }
    }
}

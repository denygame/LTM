using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TCP Client ===");
            Socket sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sckClient.Connect(new IPEndPoint(IPAddress.Loopback, 12345));
            byte[] data = new byte[1024];
            int size;

            Console.Write("Nhap so A: ");
            string soA = Console.ReadLine();
            Console.Write("Nhap so B: ");
            string soB = Console.ReadLine();
            string send = soA + "\\" + soB;
            sckClient.Send(Encoding.ASCII.GetBytes(send));
            size = sckClient.Receive(data);
            string receive = Encoding.ASCII.GetString(data, 0, size);
            Console.WriteLine("Server USCLN: " + receive);
            sckClient.Close();
            Console.ReadLine();
        }
    }
}

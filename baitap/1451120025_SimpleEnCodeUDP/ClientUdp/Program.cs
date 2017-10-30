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
            Console.WriteLine("Nguyen Thanh Huy - 1451120025");
            Console.WriteLine("------------UDP Client-----------\r\n");
            Socket sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint serverEp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            byte[] data = new byte[1024];
            sckClient.SendTo(Encoding.ASCII.GetBytes("Hello"), serverEp);

            while (true)
            {
                Console.WriteLine("\r\nChon chuc nang <0: ma hoa> & <1: giai ma>");
                string userInput;
                bool check;
                do
                {
                    check = false;
                    Console.Write("==> Nhap chuc nang: ");
                    userInput = Console.ReadLine();
                    if (userInput.Length == 1)
                        foreach (var i in userInput)
                            if (i == '0' || i == '1') check = true;
                } while (!check);
                sckClient.SendTo(Encoding.ASCII.GetBytes(userInput), serverEp);

                Console.Write("Nhap chuoi S: ");
                string strS = Console.ReadLine();
                sckClient.SendTo(Encoding.ASCII.GetBytes(strS), serverEp);

                Console.Write("Nhap so N: ");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n))
                    Console.Write("\t==> Chi nhap so nguyen: ");
                sckClient.SendTo(Encoding.ASCII.GetBytes(n.ToString()), serverEp);

                int size = sckClient.ReceiveFrom(data, ref serverEp);
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, size) + "\r\n");

                Console.WriteLine("Ban co muon tiep tuc <c/k>?");
                string loop;
                bool checkLoop;
                do
                {
                    checkLoop = false;
                    Console.Write("==> < Co: c ; Khong: k >: ");
                    loop = Console.ReadLine();
                    if (loop.Length == 1)
                        foreach (var i in loop)
                            if (i == 'c' || i == 'k') checkLoop = true;
                } while (!checkLoop);
                sckClient.SendTo(Encoding.ASCII.GetBytes(loop), serverEp);
                if (loop == "k") break;
            }

            Console.WriteLine("===> Ngat ket noi!");
            sckClient.Close();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1451120025 - Nguyen Thanh Huy\r\n");
            Console.WriteLine("----------USCLN Client----------");
            Socket sck = TcpCLIENT.getSck("127.0.0.1", 12345);

            while (true)
            {
                Console.WriteLine();

                Console.Write("Client: Nhap so a = ");
                int a;
                while (!int.TryParse(Console.ReadLine(), out a))
                    Console.Write("\t==> Chi nhap so nguyen: ");

                Console.Write("Client: Nhap so b = ");
                int b;
                while (!int.TryParse(Console.ReadLine(), out b))
                    Console.Write("\t==> Chi nhap so nguyen: ");

                TcpCLIENT.sendData(Encoding.ASCII.GetBytes(a + "/" + b), sck);//send a va b

                var result = TcpCLIENT.receiveData(sck);
                Console.WriteLine("Server: " + Encoding.ASCII.GetString(result.Item1, 0, result.Item2));
            }

            sck.Close();
            Console.ReadKey();
        }
    }
}

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
            Console.WriteLine("Nguyen Thanh Huy - 1451120025");
            Console.WriteLine("-------------- TCP Client --------------\r\n");
            Socket sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            sckClient.Connect(ipep);
            Console.WriteLine("Ket noi thanh cong!\r\n");
            string userInput = "";
            float num1, num2;
        nhan1:
            Console.Write("Nhap so thu nhat: ");
            userInput = Console.ReadLine();

            try
            {
                num1 = float.Parse(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chi nhap so!");
                goto nhan1;
            }
        nhan2:
            Console.Write("Nhap so thu hai: ");
            userInput = Console.ReadLine();

            try
            {
                num2 = float.Parse(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chi nhap so!");
                goto nhan2;
            }
            string str = num1 + ";" + num2;
            sckClient.Send(Encoding.ASCII.GetBytes(str));

            var data = new byte[1024];
            int size = sckClient.Receive(data);
            string recv = Encoding.ASCII.GetString(data, 0, size);
            string[] listResult = recv.Split(';');
            Console.WriteLine("Server tra loi!\r\n\tTong: " + listResult[0] + "\r\n\tHieu: " + listResult[1] + "\r\n\tTich: " + listResult[2] + "\r\n\tThuong: " + listResult[3]);

            Console.WriteLine("\r\nKet Thuc!");
            sckClient.Close();
            Console.ReadKey();
        }
    }
}

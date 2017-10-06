using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TimeTCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sckClient = ClassTCPclient.connectToServer("127.0.0.1", 12345);
            Console.WriteLine("+ Nhap 1 de hien thi Time\r\n+ Nhap 2 de hien thi Date\r\n+ Nhap 3 de hien thi Date & Time");
            
            string userInput;
            bool check;
            do
            {
                check = false;
                Console.Write("==> Nhap chuc nang: ");
                userInput = Console.ReadLine();
                if (userInput.Length == 1)
                    foreach (var i in userInput)
                        if (i == '1' || i == '2' || i == '3') check = true;
            } while (!check);
            ClassTCPclient.send(Encoding.ASCII.GetBytes(userInput), sckClient);
            Console.WriteLine("Server tra loi: " + ClassTCPclient.receiveString(sckClient));
            sckClient.Close();

            Console.ReadKey();
        }
    }
}

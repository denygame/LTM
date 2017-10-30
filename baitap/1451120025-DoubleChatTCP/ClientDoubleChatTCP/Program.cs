using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientDoubleChatTCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1451120025 - Nguyen Thanh Huy");
            Console.WriteLine("\r\n----------------TCP Client----------------");

            try
            {
                Socket sck = ClientTcp.connectToServer("127.0.0.1", 9999);
                var info = ClientTcp.receive(sck);//nhận thông tin client...
                int numClient = int.Parse(Encoding.ASCII.GetString(info.Item1, 0, info.Item2));
                Console.WriteLine("Server thong bao ban la: Client " + numClient + "\r\n");

                var fullClient = ClientTcp.receive(sck);//server thong bao đủ 2 client, chat
                Console.WriteLine(Encoding.ASCII.GetString(fullClient.Item1, 0, fullClient.Item2) + "\r\n");

                while (true)
                {
                    //client 1 send
                    if (numClient == 1)
                    {
                        Console.Write("Me: ");
                        ClientTcp.send(Encoding.ASCII.GetBytes(Console.ReadLine()), sck);
                    }
                    else
                    {
                        var data = ClientTcp.receive(sck);
                        Console.WriteLine(Encoding.ASCII.GetString(data.Item1, 0, data.Item2));
                    }

                    //client 2 send
                    if (numClient == 1)
                    {
                        var data = ClientTcp.receive(sck);
                        Console.WriteLine(Encoding.ASCII.GetString(data.Item1, 0, data.Item2));
                    }
                    else
                    {
                        Console.Write("Me: ");
                        ClientTcp.send(Encoding.ASCII.GetBytes(Console.ReadLine()), sck);
                    }
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}

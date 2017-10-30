using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerDoubleChatTCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1451120025 - Nguyen Thanh Huy");
            Console.WriteLine("\r\n----------------TCP Server----------------");

            Socket sckServer = ServerTcp.getSckServer(9999);
            List<Socket> listSckClient = new List<Socket>();
            int count = 0;

            Console.WriteLine("Dang cho ket noi..........");

            while (count < 2)
            {
                Socket sckClient = ServerTcp.getClient(sckServer);
                listSckClient.Add(sckClient);
                count += 1;
                ServerTcp.sendData(Encoding.ASCII.GetBytes(count.ToString()), sckClient);
            }

            foreach (var i in listSckClient)
                ServerTcp.sendData(Encoding.ASCII.GetBytes("Server thong bao: Da du 2 client, bat dau chat!"), i);
            Console.WriteLine("Bat dau chat!!!\r\n");

            string str = null;

            try
            {
                while (true)
                {
                    var client1 = ServerTcp.receive(listSckClient[0]);
                    string dataClient1 = Encoding.ASCII.GetString(client1.Item1, 0, client1.Item2);
                    str = "Client 1: " + dataClient1;
                    Console.WriteLine("Client 1 -> Client 2: " + dataClient1);
                    ServerTcp.sendData(Encoding.ASCII.GetBytes(str), listSckClient[1]);

                    var client2 = ServerTcp.receive(listSckClient[1]);
                    string dataClient2 = Encoding.ASCII.GetString(client2.Item1, 0, client2.Item2);
                    str = "Client 2: " + dataClient2;
                    Console.WriteLine("Client 2 -> Client 1: " + dataClient2);
                    ServerTcp.sendData(Encoding.ASCII.GetBytes(str), listSckClient[0]);
                }
            }
            catch(Exception e)
            {
                //Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}

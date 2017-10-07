using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1451120025 - Nguyen Thanh Huy\r\n");
            Console.WriteLine("----------USCLN Server----------");
            Socket sck = TcpSERVER.getSckServer(12345);
            Socket sckClient = TcpSERVER.getSckClient(sck);

            Console.WriteLine(sckClient.RemoteEndPoint + " ket noi den!");

            while (true)
            {
                Console.WriteLine();
                // nhan 2 so a b
                var twoNum = TcpSERVER.receiveData(sckClient);
                string str = Encoding.ASCII.GetString(twoNum.Item1, 0, twoNum.Item2);
                var listNum = str.Split('/');
                int soA = int.Parse(listNum[0]);
                int soB = int.Parse(listNum[1]);

                Console.WriteLine("Client: So A = " + soA + " ; So B = " + soB);

                // gui uscln
                TcpSERVER.sendData(Encoding.ASCII.GetBytes("USCLN cua <" + soA.ToString() + "," + soB.ToString() + "> la " + Uscln.solve(soA, soB).ToString()), sckClient);
            }

            sck.Close();
            sckClient.Close();
            Console.ReadKey();
        }
    }
}

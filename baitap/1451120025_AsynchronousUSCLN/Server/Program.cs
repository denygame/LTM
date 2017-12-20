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
        static Socket sckServer, sckClient;
        private static int NumberOfConnections = 0;
        static byte[] data = new byte[1024];

        static void Main(string[] args)
        {
            Console.WriteLine("=== USCLN Asynchronous ===");
            sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            EndPoint ep = new IPEndPoint(IPAddress.Any, 12345);
            sckServer.Bind(ep);
            sckServer.Listen(10);

            while (true)
                sckServer.BeginAccept(new AsyncCallback(xulyketnoi), null);
        }

        private static void xulyketnoi(IAsyncResult result)
        {
            NumberOfConnections++;
            sckClient = sckServer.EndAccept(result);
            Console.WriteLine(NumberOfConnections + ". " + sckClient.RemoteEndPoint.ToString() + " connected");
            sckServer.BeginAccept(new AsyncCallback(xulyketnoi), null);
            sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(xulydulieunhanduoc), sckClient);
        }

        private static void xulydulieunhanduoc(IAsyncResult ar)
        {
            int size;
            Socket current = (Socket)ar.AsyncState;
            size = current.EndReceive(ar);
            string recv = Encoding.ASCII.GetString(data, 0, size);
            string[] spiltls = recv.Split('\\');

            if (spiltls.Length > 1)
            {
                int numA = Convert.ToInt32(spiltls[0]);
                int numB = Convert.ToInt32(spiltls[1]);

                int response = uscln(numA, numB);
                current.Send(Encoding.ASCII.GetBytes(response.ToString()));
                current.Close();
                NumberOfConnections--;
                Console.WriteLine("Client disconnected. Number of active connections: " + NumberOfConnections);
            }
        }

        private static int uscln(int a, int b)
        {
            int kq = 0;
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            kq = a;
            return kq;
        }
    }
}

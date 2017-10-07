using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class TcpCLIENT
    {
        public static Socket getSck(string ip, int port)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Connect(ipep);
            Console.WriteLine("Ket noi thanh cong den: " + sck.RemoteEndPoint);
            return sck;
        }

        public static void sendData(byte[] data, Socket sck)
        {
            sck.Send(data);
        }

        /// <summary>
        /// Item1 la data, Item2 la size
        /// </summary>
        /// <param name="sck"></param>
        /// <returns></returns>
        public static Tuple<byte[], int> receiveData(Socket sck)
        {
            var data = new byte[1024];
            int size = sck.Receive(data);
            return new Tuple<byte[], int>(data, size);
        }
    }
}

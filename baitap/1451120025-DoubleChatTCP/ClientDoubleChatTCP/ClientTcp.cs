using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientDoubleChatTCP
{
    public class ClientTcp
    {
        public static Socket connectToServer(string ip, int port)
        {
            Socket sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);
                sckClient.Connect(ipep);
                Console.WriteLine("Ket noi den server thanh cong!");
                return sckClient;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static Tuple<byte[], int> receive(Socket sckClient)
        {
            var data = new byte[1024];
            int size = sckClient.Receive(data);
            return new Tuple<byte[], int>(data, size);
        }

        public static void send(byte[] data, Socket sckClient)
        {
            sckClient.Send(data);
        }
    }
}

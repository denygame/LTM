using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerDoubleChatTCP
{
    public class ServerTcp
    {
        public static Socket getSckServer(int port)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(IPAddress.Any, port));
            sck.Listen(5);
            return sck;
        }

        public static Socket getClient(Socket sckServer)
        {
            Socket sckClient = sckServer.Accept();
            Console.WriteLine("Ket noi tu: " + sckClient.RemoteEndPoint);
            return sckClient;
        }

        public static void sendData(byte[] data, Socket sckClient)
        {
            sckClient.Send(data);
        }

        public static Tuple<byte[], int> receive(Socket sckClient)
        {
            var data = new byte[1024];
            int size = sckClient.Receive(data);
            return new Tuple<byte[], int>(data, size);
        }
    }
}

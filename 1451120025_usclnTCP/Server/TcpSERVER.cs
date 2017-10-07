using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class TcpSERVER
    {
        public static Socket getSckServer(int port)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, port);
            Socket sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sckServer.Bind(ipep);
            sckServer.Listen(10);
            return sckServer;
        }

        public static Socket getSckClient(Socket sckServer)
        {
            return sckServer.Accept();
        }

        public static void sendData(byte[] data, Socket sckClient)
        {
            sckClient.Send(data);
        }

        public static Tuple<byte[], int> receiveData(Socket sckClient)
        {
            var data = new byte[1024];
            int size = sckClient.Receive(data);
            return new Tuple<byte[], int>(data, size);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerUdp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1451120025 - Nguyen Thanh Huy\r\n");
            Console.WriteLine("---UDP Time Server---");
            Socket sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint localEp = new IPEndPoint(IPAddress.Any, 22333);
            sckServer.Bind(localEp);

            try
            {
                byte[] data = new byte[1024];
                EndPoint epClient = new IPEndPoint(IPAddress.Any, 0);
                int size = sckServer.ReceiveFrom(data, ref epClient);
                Console.WriteLine("Nhan yeu cau tu client " + epClient.ToString());

                while (true)
                {
                    size = sckServer.ReceiveFrom(data, ref epClient);
                    string request = Encoding.ASCII.GetString(data, 0, size);

                    var list = PathInfo.getInfo(request);
                    if (list != null)
                    {
                        string respond = "Duong dan dung!\r\nDanh sach: \r\n";
                        foreach (string folder in list.Item1)
                            respond += "\t" + folder.ToUpper() + "\r\n";
                        foreach (string file in list.Item2)
                            respond += "\t" + file.ToLower() + "\r\n";
                        sckServer.SendTo(Encoding.ASCII.GetBytes(respond), epClient);
                    }
                    else
                    {
                        sckServer.SendTo(Encoding.ASCII.GetBytes("Duong dan khong hop le"), epClient);
                    }
                }
            }
            catch
            {
                Console.ReadKey();
            }
        }
    }
}

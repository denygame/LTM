using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace UDPTimeServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---UDP Time Server---");
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 12345);
            sck.Bind(ep);
            //Nhan yeu cau truy cap dich vu tu Client
            byte[] data = new byte[1024];
            EndPoint epClient = new IPEndPoint(IPAddress.Any, 0);
            int size = sck.ReceiveFrom(data, ref epClient);
            Console.WriteLine("Nhan yeu cau tu client " + epClient.ToString());
            //////////////////////////////
            while (true)
            {
                //Nhan request (1,2,3) tu Client
                size = sck.ReceiveFrom(data, ref epClient);
                string request = Encoding.ASCII.GetString(data, 0, size);
                string respond;
                DateTime dt = DateTime.Now;
                if (request == "1")//lay gio
                    respond = dt.ToShortTimeString();
                else if (request == "2")
                    respond = dt.ToShortDateString();
                else if (request == "3")
                    respond = dt.ToString();
                else
                    respond = "ERROR";
                //Gui respond
                sck.SendTo(Encoding.ASCII.GetBytes(respond),epClient);
            }
            ///////////////////////////////
            sck.Close();
            Console.ReadLine();
        }
    }
}

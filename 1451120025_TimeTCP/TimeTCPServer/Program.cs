using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TimeTCPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------TCP Server--------------");
            var sckServer = ClassTCPserver.getSocketServer(12345);
            while (true)
            {
                Socket sckClient = ClassTCPserver.getClient(sckServer);

                string func = ClassTCPserver.receiveString(sckClient);

                Console.WriteLine("Client " + sckClient.RemoteEndPoint + " yeu cau chuc nang: " + func);

                switch (func)
                {
                    case "1":
                        ClassTCPserver.sendData(Encoding.ASCII.GetBytes(DateTime.Now.TimeOfDay.ToString()), sckClient);
                        break;
                    case "2":
                        ClassTCPserver.sendData(Encoding.ASCII.GetBytes(DateTime.Now.Date.ToString()), sckClient);
                        break;
                    case "3":
                        ClassTCPserver.sendData(Encoding.ASCII.GetBytes(DateTime.Now.ToString()), sckClient);
                        break;
                }
                sckClient.Close();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ConnectionHandle
    {
        private static int NumberOfConnections = 0;
        private Socket sck;
        public ConnectionHandle(Socket sck)
        {
            this.sck = sck;
        }

        public void run()
        {
            NumberOfConnections++;
            Console.WriteLine("Client connected. Number of active connections: " + NumberOfConnections);
            byte[] data = new byte[1024];
            int size;

            size = sck.Receive(data);
            int numA = Convert.ToInt32(Encoding.ASCII.GetString(data, 0, size));
            size = sck.Receive(data);
            int numB = Convert.ToInt32(Encoding.ASCII.GetString(data, 0, size));
            int response = uscln(numA, numB);
            sck.Send(Encoding.ASCII.GetBytes(response.ToString()));
        }

        private int uscln(int a, int b)
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

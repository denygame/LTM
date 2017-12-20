using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MultiClient_Server_Asynchronous
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket sckServer, sckClient;
        byte[] data = new byte[1024];


        private void button1_Click(object sender, EventArgs e)
        {            
            sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //bind
            EndPoint ep = new IPEndPoint(IPAddress.Any, int.Parse(textBox1.Text));
            sckServer.Bind(ep);
            //listen
            sckServer.Listen(10);

            textBox2.Text = "Server start with port " + textBox1.Text + Environment.NewLine;

            //accept
            sckServer.BeginAccept(new AsyncCallback(xulyketnoi), null);
        }

        private static int NumberOfConnections = 0;
        void xulyketnoi(IAsyncResult result)
        {
            NumberOfConnections++;
            sckClient = sckServer.EndAccept(result);
            textBox2.Text += NumberOfConnections + ". " + sckClient.RemoteEndPoint.ToString() + " connected" + Environment.NewLine;
            sckServer.BeginAccept(new AsyncCallback(xulyketnoi), null);
            sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(xulydulieunhanduoc), null);
        }

        int size;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void xulydulieunhanduoc(IAsyncResult result)
        {

            //Cho nhan tiep
            sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(xulydulieunhanduoc), null);

        }
    }
}

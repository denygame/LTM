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

namespace InfoScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdStart.Enabled = true;
            cmdStop.Enabled = false;
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!existing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private bool existing = false;
        private void cmdExit_Click(object sender, EventArgs e)
        {
            existing = true;
            this.Close();
        }

        Socket sock = null;
        private void cmdStart_Click(object sender, EventArgs e)
        {
            sock = new Socket(SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any,(int)numericUpDown1.Value);
            try
            {
                sock.Bind(ep);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: Cannot bind to this port!" + ex.Message);
                return;
            }
            cmdStart.Enabled = false;
            cmdStop.Enabled = true;
            //Start receiving 
            sock.BeginReceiveFrom(buffer, 0, 1024, SocketFlags.None, ref fromEP,new AsyncCallback(handleMessage),sock);
        }
        EndPoint fromEP = new IPEndPoint(IPAddress.Any, 0);
        byte[] buffer = new byte[1024];
        private void handleMessage(IAsyncResult result)
        {
            try
            {
                int dataSize = sock.EndReceiveFrom(result, ref fromEP);
                MessageBox.Show(Encoding.ASCII.GetString(buffer, 0, dataSize));
                //Start receiving 
                sock.BeginReceiveFrom(buffer, 0, 1024, SocketFlags.None, ref fromEP, new AsyncCallback(handleMessage), sock);
            }
            catch(Exception)
            {

            }
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            sock.Close();
            sock = null;
            cmdStart.Enabled = true;
            cmdStop.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Socket sendSocket = new Socket(SocketType.Dgram, ProtocolType.Udp);
            sendSocket.EnableBroadcast = true;
            IPEndPoint ep = new IPEndPoint(IPAddress.Broadcast, (int)numericUpDown1.Value);
            sendSocket.SendTo(Encoding.ASCII.GetBytes(txtMessage.Text), ep);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            cmdExit_Click(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}

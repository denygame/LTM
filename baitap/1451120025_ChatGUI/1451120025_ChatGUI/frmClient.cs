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

namespace _1451120025_ChatGUI
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }
        Socket sckClient;
        delegate void DesignChange(string s);
        byte[] data = new byte[1024];

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //tao socket
            sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //connect
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(txtServerIP.Text), (int)numServerPort.Value);
            sckClient.BeginConnect(ep, new AsyncCallback(connectSolution), null);
        }

        private void connectSolution(IAsyncResult ar)
        {
            sckClient.EndConnect(ar);
            statusStrip1.Invoke(new DesignChange(lblStatusChange), new object[] { "Connected" });
            sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(receiveSolution), null);
        }

        private void receiveSolution(IAsyncResult ar)
        {
            int size = sckClient.EndReceive(ar);
            string receive = Encoding.ASCII.GetString(data, 0, size);

            if (receive == "ServerClosed")
            {
                MessageBox.Show("Server Closed!");
                sckClient.Close();
                Application.Exit();
            }
            else
            {

                string str = "Server: " + receive;
                listBox.Invoke(new DesignChange(listBoxChange), new object[] { str });
                sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(receiveSolution), null);
            }
        }

        private void listBoxChange(string s)
        {
            listBox.Items.Add(s);
            this.listBox.SelectedIndex = this.listBox.Items.Count - 1;
        }

        private void lblStatusChange(string s)
        {
            this.statusChange.Text = s;
            this.statusStrip1.Update();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (sckClient.Connected)
            {
                sckClient.Send(Encoding.ASCII.GetBytes(txtSend.Text));
                listBoxChange("Client: " + txtSend.Text);
                txtSend.Text = "";
            }
        }

        private void txtSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                btnSend_Click(null, null);
            }
        }

        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sckClient.Connected)
            {
                sckClient.Send(Encoding.ASCII.GetBytes("ClientExit"));
            }
        }
    }
}

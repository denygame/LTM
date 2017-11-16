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
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        Socket sckServer, sckAccept;
        byte[] data = new byte[1024];
        delegate void DesignChange(string str);

        private void btnStart_Click(object sender, EventArgs e)
        {
            sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sckServer.Bind(new IPEndPoint(IPAddress.Any, (int)numServerPort.Value));
            sckServer.Listen(5);

            statusStrip1.Invoke(new DesignChange(lblStatusChange), new object[] { "Waiting..........." });
            sckServer.BeginAccept(new AsyncCallback(acceptSolution), null);
        }

        private void acceptSolution(IAsyncResult ar)
        {
            sckAccept = sckServer.EndAccept(ar);
            //cap nhat giao dien
            //statusChange.Invoke()
            statusStrip1.Invoke(new DesignChange(lblStatusChange), new object[] { "Client: " + sckAccept.RemoteEndPoint + " connected!" });
            sckAccept.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(receiveSolution), null);
        }

        private void receiveSolution(IAsyncResult ar)
        {
            int size = sckAccept.EndReceive(ar);
            string receive = Encoding.ASCII.GetString(data, 0, size);

            if (receive == "ClientExit")
            {
                MessageBox.Show("Client " + sckAccept.RemoteEndPoint + " exit!");
                sckAccept.Close();
                statusStrip1.Invoke(new DesignChange(lblStatusChange), new object[] { "Waiting..........." });
                sckServer.BeginAccept(new AsyncCallback(acceptSolution), null);
            }
            else
            {

                string receiveMess = "Client (" + sckAccept.RemoteEndPoint + "): " + receive;
                listBox.Invoke(new DesignChange(listBoxChange), new object[] { receiveMess });
                sckAccept.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(receiveSolution), null);
            }
        }

        private void listBoxChange(string str)
        {
            listBox.Items.Add(str);
            this.listBox.SelectedIndex = this.listBox.Items.Count - 1;
        }

        private void lblStatusChange(string str)
        {
            this.statusChange.Text = str;
            this.statusStrip1.Update();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (sckAccept.Connected)
            {
                sckAccept.Send(Encoding.ASCII.GetBytes(txtSend.Text));
                listBoxChange("Server: " + txtSend.Text);
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

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sckAccept.Connected)
            {
                sckAccept.Send(Encoding.ASCII.GetBytes("ServerClosed"));
            }
        }

    }
}

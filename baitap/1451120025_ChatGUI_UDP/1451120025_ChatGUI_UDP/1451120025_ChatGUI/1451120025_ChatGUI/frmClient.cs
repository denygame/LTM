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
        Socket sck;
        EndPoint ep;
        delegate void DesignChange(string s);
        byte[] data = new byte[1024];

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ep = new IPEndPoint(IPAddress.Parse(txtServerIP.Text),(int)numServerPort.Value);

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SendTo(Encoding.ASCII.GetBytes("hi"), ep);

            sck.BeginReceiveFrom(data, 0, 1024, SocketFlags.None, ref ep, new AsyncCallback(receiveSolution), null);

            statusStrip1.Invoke(new DesignChange(lblStatusChange), new object[] { "Waiting..........." });
        }

        private void receiveSolution(IAsyncResult ar)
        {


            //Goi ham EndReceive
            int size = sck.EndReceiveFrom(ar, ref ep);
            statusStrip1.Invoke(new DesignChange(lblStatusChange), new object[] { "Connected" });
            //Xu ly du lieu nhan duoc trong data[]
            String thongdiep = Encoding.ASCII.GetString(data, 0, size);
            string str = "Server: " + thongdiep;
            listBox.Invoke(new DesignChange(listBoxChange), new object[] { str });
            
            //Cho nhan tiep
            sck.BeginReceiveFrom(data, 0, 1024, SocketFlags.None, ref ep, new AsyncCallback(receiveSolution), null);
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
            sck.SendTo(Encoding.ASCII.GetBytes(txtSend.Text), ep);
            listBoxChange("Client: " + txtSend.Text);
            txtSend.Text = "";
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
           
        }
    }
}

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

        Socket sck;
        byte[] data = new byte[1024];
        EndPoint epClient = new IPEndPoint(IPAddress.Any, 0);


        delegate void DesignChange(string str);

        private void btnStart_Click(object sender, EventArgs e)
        {

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.Bind(new IPEndPoint(IPAddress.Any, (int)this.numServerPort.Value));
            sck.BeginReceiveFrom(data, 0, 1024, SocketFlags.None, ref epClient, new AsyncCallback(receiveSolution), null);

            statusStrip1.Invoke(new DesignChange(lblStatusChange), new object[] { "Waiting..........." });
        }

        private void receiveSolution(IAsyncResult ar)
        {
            //Goi ham EndReceive
            int size = sck.EndReceiveFrom(ar, ref epClient);
            //cap nhat giao dien
            //statusChange.Invoke()
            statusStrip1.Invoke(new DesignChange(lblStatusChange), new object[] { "Client: " + epClient + " connected!" });
            //Xu ly du lieu nhan duoc trong data[]
            string thongdiep = Encoding.ASCII.GetString(data, 0, size);
            string receiveMess = "Client (" + epClient + "): " + thongdiep;
            listBox.Invoke(new DesignChange(listBoxChange), new object[] { receiveMess });
            //Cho nhan tiep
            sck.BeginReceiveFrom(data, 0, 1024, SocketFlags.None, ref epClient, new AsyncCallback(receiveSolution), null);
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
            sck.SendTo(Encoding.ASCII.GetBytes(txtSend.Text), epClient);
            listBoxChange("Server: " + txtSend.Text);
            txtSend.Text = "";
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
           
        }

    }
}

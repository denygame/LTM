using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1451120025_SimpleChat
{
    public partial class frmMain : Form
    {
        //client 0, server 1
        private int mode = -1;
        private bool checkServer = false;
        private bool checkClient = false;
        Socket sckClient, sckServer;
        byte[] data = new byte[1024];
        delegate void DesignChange(string str);


        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFile.FileName))
                    {
                        txtTextSend.Text = sr.ReadToEnd();
                        sr.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
                rTxtChat.Focus();
                rTxtChat.SelectionStart = rTxtChat.Text.Length;

                txtTextSend.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string test = rTxtChat.Text.Trim();
            if (test == null || test.Length < 1)
            {
                MessageBox.Show("Không thể save!");
            }
            else
            {
                SaveFileDialog a = new SaveFileDialog();
                a.Filter = "txt file|*.txt";
                DialogResult result = a.ShowDialog();

                if (result == DialogResult.OK)
                    using (StreamWriter sw = new StreamWriter(a.FileName))
                        sw.WriteLine(rTxtChat.Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa nội dung log?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rTxtChat.Text = "";
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    e.Cancel = true;
            if(this.mode == 1)
            {
                btnStopService_Click(null, null);
            }
            if (this.mode == 0)
            {
                btnDis_Click(null, null);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStartSevice_Click(object sender, EventArgs e)
        {
            this.mode = 1;
            this.checkServer = true;
            closeModeOther();

            sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sckServer.Bind(new IPEndPoint(IPAddress.Any, (int)nUdPortServer.Value));
            sckServer.Listen(100);

            this.resetServer();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.mode = 0;
            this.checkClient = true;
            closeModeOther();

            sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(cbConnect.Text), (int)numPortFromClient.Value);
            sckClient.BeginConnect(ep, new AsyncCallback(connectSolution), null);
        }

        private void txtTextSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                btnSend_Click(null, null);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendData();
        }

        private void txtTextSend_TextChanged(object sender, EventArgs e)
        {
            txtTextSend.Text = txtTextSend.Text.Replace(Environment.NewLine, "");
        }

        private void btnStopService_Click(object sender, EventArgs e)
        {
            if (this.mode == 1)
            {
                this.mode = -1;
                this.checkServer = false;

                if (sckClient != null && sckClient.Connected)
                {
                    sckClient.Send(Encoding.ASCII.GetBytes("exitServer"));
                    sckClient.Close();
                }
                resetToBegin();
                closeModeOther();
                sckServer.Close();
            }
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            if (this.mode == 0)
            {
                this.mode = -1;
                sckClient.Send(Encoding.ASCII.GetBytes("clientClose"));
                this.checkClient = false;
                sckClient.Close();
                resetToBegin();
                closeModeOther();
            }
        }




        private void connectSolution(IAsyncResult ar)
        {
            if (!checkClient)
            {
                resetToBegin();
                closeModeOther();
                return;
            }
            sckClient.EndConnect(ar);
            statusStrip1.Invoke(new DesignChange(lblStatusChange), new object[] { "Connected" });
            lblText.Invoke(new DesignChange(lblTextChange), new object[] { "Client TCP" });
            sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(receiveSolution), null);
        }

        private void resetToBegin()
        {
            this.statusStrip1.Invoke(new DesignChange(lblStatusChange), new object[] { "Unknow" });
            this.lblText.Invoke(new DesignChange(lblTextChange), new object[] { "Simple Chat Application" });
        }

        private void resetServer()
        {
            this.statusStrip1.Invoke(new DesignChange(lblStatusChange), new object[] { "Waiting for Connections" });
            this.lblText.Invoke(new DesignChange(lblTextChange), new object[] { "Server TCP" });

            sckServer.BeginAccept(new AsyncCallback(acceptSolution), null);
        }

        private void closeModeOther()
        {
            if (mode == -1)
            {
                foreach (Control item in tabClient.Controls)
                    item.Enabled = true;
                foreach (Control item in tabServer.Controls)
                    item.Enabled = true;
            }

            if (mode == 1)
            {
                foreach (Control item in tabClient.Controls)
                    item.Enabled = false;
            }

            if (mode == 0)
            {
                foreach (Control item in tabServer.Controls)
                    item.Enabled = false;
            }
        }

        private void lblTextChange(string str)
        {
            this.lblText.Text = str;
        }

        private void acceptSolution(IAsyncResult ar)
        {
            if (!checkServer)
            {
                resetToBegin();
                closeModeOther();
                return;
            }
            sckClient = sckServer.EndAccept(ar);

            statusStrip1.Invoke(new DesignChange(lblStatusChange), new object[] { "Client: " + sckClient.RemoteEndPoint + " connected!" });
            sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(receiveSolution), null);
        }

        private void receiveSolution(IAsyncResult ar)
        {
            //server
            if (this.mode == 1)
            {
                int size = sckClient.EndReceive(ar);
                string msgFromClient = Encoding.ASCII.GetString(data, 0, size);
                if (msgFromClient == "clientClose")
                {
                    sckClient.Close();
                    resetServer();
                    return;
                }
                string receiveMess = "Client (" + sckClient.RemoteEndPoint + "): " + msgFromClient;
                rTxtChat.Invoke(new DesignChange(rTextboxChange), new object[] { receiveMess });
                sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(receiveSolution), null);
            }

            //client
            if (this.mode == 0)
            {
                if (!checkClient)
                {
                    resetToBegin();
                    return;
                }

                int size = sckClient.EndReceive(ar);
                string msgFromServer = Encoding.ASCII.GetString(data, 0, size);
                if (msgFromServer == "exitServer")
                {
                    sckClient.Close();
                    rTxtChat.Invoke(new DesignChange(rTextboxChange), new object[] { "Server close !!!" });
                    this.mode = -1;
                    resetToBegin();
                    closeModeOther();
                    return;
                }
                string str = "Server: " + msgFromServer;
                rTxtChat.Invoke(new DesignChange(rTextboxChange), new object[] { str });
                sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(receiveSolution), null);
            }
        }

        private void rTextboxChange(string str)
        {
            rTxtChat.Text += str + Environment.NewLine;
        }

        private void lblStatusChange(string str)
        {
            this.sttChange.Text = str;
            this.statusStrip1.Update();
        }

        private void rTxtChat_TextChanged(object sender, EventArgs e)
        {
            rTxtChat.SelectionStart = rTxtChat.TextLength;
            rTxtChat.ScrollToCaret();
        }

        private void sendData()
        {
            if (this.mode != -1)
            {
                if (checkClient == true || checkServer == true)
                {
                    if (sckClient.Connected)
                    {
                        sckClient.Send(Encoding.ASCII.GetBytes(txtTextSend.Text));
                        rTextboxChange("Me: " + txtTextSend.Text);

                        txtTextSend.Clear();
                    }
                }
            }
        }
    }
}

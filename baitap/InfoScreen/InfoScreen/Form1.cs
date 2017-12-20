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
using System.Timers;
using System.Windows.Forms;

namespace InfoScreen
{
    public partial class Form1 : Form
    {
        private List<Tuple<string, string>> ls = new List<Tuple<string, string>>();

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
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, (int)numericUpDown1.Value);
            try
            {
                sock.Bind(ep);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Cannot bind to this port!" + ex.Message);
                return;
            }
            cmdStart.Enabled = false;
            cmdStop.Enabled = true;


            timer1.Tick += new EventHandler(timer1_Tick);
            // Set the Interval to 10 seconds.
            timer1.Interval = 10000;
            timer1.Start();

            checkBox1.Enabled = true;

            //Start receiving 
            sock.BeginReceiveFrom(buffer, 0, 1024, SocketFlags.None, ref fromEP, new AsyncCallback(handleMessage), sock);

            sendMsg("NAME;" + txtNickName.Text);
        }

        EndPoint fromEP = new IPEndPoint(IPAddress.Any, 0);
        byte[] buffer = new byte[1024];

        private void timer1_Tick(object sender, EventArgs e)
        {
            sendMsg("NAME;" + txtNickName.Text);
        }


        private void handleMessage(IAsyncResult result)
        {
            try
            {
                int dataSize = sock.EndReceiveFrom(result, ref fromEP);
                string s = Encoding.ASCII.GetString(buffer, 0, dataSize);

                string fiveChar = s[0].ToString() + s[1] + s[2] + s[3] + s[4];
                if (fiveChar == "ECHO;")
                {
                    string str = s.Remove(0, 5);
                    notifyIcon1.BalloonTipText = "[" + DateTime.Now + "] " + str;
                    notifyIcon1.ShowBalloonTip(1000);
                }
                if (fiveChar == "NAME;")
                {
                    string str = s.Remove(0, 5);
                    if (!ls.Contains(new Tuple<string, string>(((IPEndPoint)fromEP).Address.ToString(), str)))
                    {
                        ls.Add(new Tuple<string, string>(((IPEndPoint)fromEP).Address.ToString(), str));
                        listBox1.Items.Add(str);
                    }
                }
                if (fiveChar == "STOP;")
                {
                    string str = s.Remove(0, 5);
                    if (ls.Contains(new Tuple<string, string>(((IPEndPoint)fromEP).Address.ToString(), str)))
                    {
                        ls.Remove(new Tuple<string, string>(((IPEndPoint)fromEP).Address.ToString(), str));
                        listBox1.Items.Remove(str);
                    }
                }

                //Start receiving 
                sock.BeginReceiveFrom(buffer, 0, 1024, SocketFlags.None, ref fromEP, new AsyncCallback(handleMessage), sock);
            }
            catch (Exception)
            {

            }
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            sendMsg("STOP;" + txtNickName.Text);
            timer1.Stop();

            sock.Close();
            sock = null;
            cmdStart.Enabled = true;
            cmdStop.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                sendMsg("ECHO;" + txtMessage.Text);
            }
            else
            {
                sendMsg("ECHO;" + txtMessage.Text, cbUser.SelectedText);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            cmdExit_Click(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
        }


        private void sendMsg(string msg, string type = null)
        {
            Socket sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            if (type != null)
            {
                string ip = (cbUser.SelectedItem as Tuple<string, string>).Item1;
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), (int)numericUpDown1.Value);
                sendSocket.SendTo(Encoding.ASCII.GetBytes(msg), ipep);
                return;
            }

            sendSocket.EnableBroadcast = true;
            IPEndPoint ep = new IPEndPoint(IPAddress.Broadcast, (int)numericUpDown1.Value);
            sendSocket.SendTo(Encoding.ASCII.GetBytes(msg), ep);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cbUser.Enabled = true;
                cbUser.DataSource = ls;
                cbUser.DisplayMember = "Item2";
                button1.Text = "Send";
            }
            else
            {
                cbUser.DataSource = null;
                cbUser.Enabled = false;
                button1.Text = "Send Broadcast";
            }
        }
    }
}

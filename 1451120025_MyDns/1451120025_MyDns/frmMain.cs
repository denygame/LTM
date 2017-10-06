using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1451120025_MyDns
{
    public partial class frmMain : Form
    {
        public void showInfo(string s)
        {
            this.Text = s;
            IPHostEntry entry = Dns.GetHostEntry(s);
            richTextBox_KQ.Text = entry.HostName;
            foreach (var ip in entry.AddressList)
            {
                richTextBox_KQ.Text += "\r\n" + ip.ToString();
            }
        }


        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showInfo(txtHost.Text);
        }
    }
}

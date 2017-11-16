using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1451120025_ChatGUI
{
    public partial class frmBegin : Form
    {
        public frmBegin()
        {
            InitializeComponent();
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (radServer.Checked == true)
            {
                frmServer f = new frmServer();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                frmClient f = new frmClient();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}

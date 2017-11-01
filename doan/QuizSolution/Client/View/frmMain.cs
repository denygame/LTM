using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.RowStyles[0].Height = bunifuCustomLabel1.Height;
        }


        private void panel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

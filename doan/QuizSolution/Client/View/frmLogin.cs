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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            PanelTransition.Hide(panelProcess);
            PanelTransition.ShowSync(panelProcess);
            this.Width = 310;
            btnClose.Location = new Point(135, 4);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.Width = 620;
            btnClose.Location = new Point(290, 4);
            PanelTransition.ShowSync(panelProcess);
        }


    }
}

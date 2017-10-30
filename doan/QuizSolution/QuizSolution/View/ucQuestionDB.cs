using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.View
{
    public partial class ucQuestionDB : UserControl
    {
        public ucQuestionDB()
        {
            InitializeComponent();
        }


        private void ucQuestionDB_Load(object sender, EventArgs e)
        {
            resizeFill();
        }

        private void lblMsg_MouseHover(object sender, EventArgs e)
        {
            lblMsg.ForeColor = Color.Black;
        }

        private void lblMsg_MouseLeave(object sender, EventArgs e)
        {
            lblMsg.ForeColor = Color.Gray;
        }



        public void resizeFill()
        {
            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
        }

    }
}

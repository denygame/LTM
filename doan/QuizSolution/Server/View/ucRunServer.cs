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
    public partial class ucRunServer : UserControl
    {
        public ucRunServer()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        public void resizeFill()
        {
            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
        }

        private void ucRunServer_Load(object sender, EventArgs e)
        {
            resizeFill();
        }
    }
}

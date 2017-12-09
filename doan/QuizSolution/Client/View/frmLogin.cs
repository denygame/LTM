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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View
{
    public partial class frmLogin : Form
    {
        private Socket sck;
        private byte[] data = new byte[1024];


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) { e.Handled = true; }
        }


        private void frmLogin2_Load(object sender, EventArgs e)
        {
            PanelTransition.Hide(panelProcess);
            PanelTransition.ShowSync(panelProcess);
            this.Width = 310;
            btnClose.Location = new Point(135, 4);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                this.Width = 620;
                btnClose.Location = new Point(290, 4);
                PanelTransition.ShowSync(panelProcess);

                int size;
                sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    sck.Connect(IPAddress.Parse(txtIpServer.Text), Convert.ToInt32(txtPort.Text));
                    // size = sck.Receive(data);//size server transfer

                    //processBar.MaxValue = Convert.ToInt32(Encoding.ASCII.GetString(data, 0, size));

                    size = sck.Receive(data);//object para
                    Controller.ParaObject para = new Controller.ParaObject(data);
                    Controller.Constant.time = para.Time;

                    if (para.GetDB > 0)
                    {
                        MessageBox.Show(para.GetDB.ToString());
                        for (int i = 0; i < para.GetDB; i++)
                        {
                            size = sck.Receive(data);
                            Model.Question a = new Model.Question(data);
                            MessageBox.Show(a.Id.ToString()+"/"+a.Content);
                            sck.Send(Encoding.ASCII.GetBytes("done"));
                        }
                    }

                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.ToString());
                    sck.Close();
                }




            }
            else
            {
                MessageBox.Show("Bạn phải điền đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmMain()).ShowDialog();
        }











        private bool validate()
        {
            if (txtCode.Text.Trim().Length == 0) return false;
            if (txtName.Text.Trim().Length == 0) return false;
            if (txtClass.Text.Trim().Length == 0) return false;
            if (txtIpServer.Text.Trim().Length == 0) return false;
            if (txtPort.Text.Trim().Length == 0) return false;
            return true;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sck != null) sck.Close();
        }
    }
}

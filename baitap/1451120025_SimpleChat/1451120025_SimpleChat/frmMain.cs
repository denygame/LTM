using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1451120025_SimpleChat
{
    public partial class frmMain : Form
    {
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
                        rTxtChat.Text += "\r\n" + sr.ReadToEnd();
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
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

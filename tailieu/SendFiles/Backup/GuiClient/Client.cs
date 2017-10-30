using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GuiClient
{
    public partial class Client : Form
    {
        private Stream stmReader = null;
        private NetworkStream nwkStream = null;
        private Stream stmWriter = null;
        private TcpClient tcpClient = null;
     
        public Client()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(SaveFile));
            t.Start();
        }
        private void SaveFile() {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtFileName.Text = saveFileDialog.FileName;
                lblMessage.Text = null;
            }
            try
            {
                tcpClient = new TcpClient("localhost", 12345);
                nwkStream = tcpClient.GetStream();
                stmReader = nwkStream;
                stmWriter = File.OpenWrite(txtFileName.Text);
                byte[] buff = new byte[1024];
                int len = 0;
                lblMessage.Text = "Receiving";
                while ((len = stmReader.Read(buff, 0, 1024)) > 0)
                {
                    stmWriter.Write(buff, 0, len);
                    stmWriter.Flush();
                }
                lblMessage.Text = "File has received succesfully!";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            
            finally
            {
                nwkStream.Close();
                stmWriter.Close();
                stmReader.Close();
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
    }
}
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

namespace RunServer
{
    public partial class Server : Form
    {
        private NetworkStream nwkStream = null;
        private Socket socketForClient = null;
        private TcpListener tcpListener = null;
        private Stream stmReader = null;
        private Stream stmWriter = null;
        public Server()
        {
            InitializeComponent();
        }
               
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtFileName.Text = fileDialog.FileName;
                lblMessage.Text = null;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(startSever));
            t.Start();
        }

        private void startSever() {
            try
            {
                lblMessage.Text = "Listening";
                tcpListener = new TcpListener(12345);
                tcpListener.Start();
                socketForClient = tcpListener.AcceptSocket();
                
                if (socketForClient.Connected)
                {
                    nwkStream = new NetworkStream(socketForClient);
                    stmReader = File.OpenRead(txtFileName.Text);
                    stmWriter = nwkStream;
                    FileInfo flInfo = new FileInfo(txtFileName.Text);
                    int size = Convert.ToInt32(flInfo.Length);
                    byte[] buff = new byte[1024];
                    int len = 0;
                    int progress = 0;
                    lblMessage.Text = "Starting";
                    while ((len = stmReader.Read(buff, 0, 1024)) != 0)
                    {
                        progress += len;
                        pgbStatus.Maximum = size;
                        pgbStatus.Value = progress;
                        lblProgressbar.Text=progress.ToString()+" Byte of "+size +" Byte";
                        stmWriter.Write(buff, 0, len);
                        stmWriter.Flush();
                    }
                    lblMessage.Text = "File has sent succesfully!";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (socketForClient != null)
                {
                    socketForClient.Close();
                    nwkStream.Close();
                    stmWriter.Close();
                    stmReader.Close();
                    tcpListener.Stop();
                }
            }
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }
    }
}

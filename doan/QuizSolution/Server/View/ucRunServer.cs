using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server.View
{
    public partial class ucRunServer : UserControl
    {
        #region -- Parameters --

        private event EventHandler<Controller.EventSendData> eventStartServer;
        public event EventHandler<Controller.EventSendData> EventStartServer
        {
            add { eventStartServer += value; }
            remove { eventStartServer -= value; }
        }

        public event EventHandler StopServer;

        private volatile bool startServer = false;
        private Socket sckServer;
        private Thread Listening = null;

        #endregion

        #region -- Singlethon --

        private static ucRunServer instance = null;

        public static ucRunServer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucRunServer();
                }
                return instance;
            }
        }

        public ucRunServer()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        #endregion


        #region -- Event --

        private void ucRunServer_Load(object sender, EventArgs e)
        {
            resizeFill();
            btnStop.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!startServer)
            {
                string path = Path.GetDirectoryName(Application.ExecutablePath);
                path = Path.Combine(path, Controller.Constant.nameFolderSaveFile);
                path = Path.Combine(path, Controller.Constant.nameFileSetting);

                if (File.Exists(path))
                {
                    Controller.IO_INI ini = new Controller.IO_INI(path);
                    string ip = ini.IniReadValue(Controller.Constant.sectionInfo, Controller.Constant.keyIP);
                    string port = ini.IniReadValue(Controller.Constant.sectionInfo, Controller.Constant.keyPort);

                    eventStartServer(this, new Controller.EventSendData(ip, port));

                    sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        sckServer.Bind(new IPEndPoint(IPAddress.Any, Convert.ToInt32(port)));
                        sckServer.Listen(100);
                        AppendText(txtCmd, "Server start. Waiting for client ..........", new Tuple<int, int, int>(165, 42, 42));
                    }
                    catch (SocketException ex)
                    {
                        MessageBox.Show(ex.ToString(), "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    startServer = true;

                    Listening = new Thread(() =>
                      {
                          try
                          {
                              while (startServer)
                              {
                                  Socket sckClient = sckServer.Accept();

                                  Controller.ConnectionHandle server = new Controller.ConnectionHandle(sckClient, txtCmd);

                                  server.Run();
                              }
                          }
                          catch (Exception ex)
                          {
                              //MessageBox.Show(ex.ToString(), "Thread", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          }
                      });
                    Listening.IsBackground = true;
                    Listening.Start();


                    btnStart.Visible = false;
                    btnStop.Visible = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file " + Controller.Constant.nameFileSetting + "! Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                AppendText(txtCmd, "Server was started!", new Tuple<int, int, int>(165, 42, 42));
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopServer();
        }

        #endregion


        #region -- Method --

        public void stopServer(string str = null)
        {
            Controller.ConnectionHandle conn = new Controller.ConnectionHandle(this.txtCmd);

            conn.stopServer(str);

            startServer = false;

            if (sckServer != null)
            {
                sckServer.Close();
                StopServer(this, new EventArgs());
            }

            btnStop.Visible = false;
            btnStart.Visible = true;

            if (Listening != null) Listening.Abort();
        }

        private void AppendText(RichTextBox box, string text, Tuple<int, int, int> color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = box.TextLength;

            box.SelectionColor = Color.FromArgb(color.Item1, color.Item2, color.Item3);
            box.AppendText(text + "\r\n");
            box.SelectionColor = box.ForeColor;
        }

        public void resizeFill()
        {
            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
        }

        #endregion
    }
}

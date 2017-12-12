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
        private byte[] data;
        private List<Model.Question> lsquesDB = new List<Model.Question>();
        private List<Model.Question> lsquesFile = new List<Model.Question>();
        private List<Model.Answer> lsansDB = new List<Model.Answer>();
        private List<Model.Answer> lsansFile = new List<Model.Answer>();

        private List<Tuple<int, Model.Question>> quesList = null;
        private List<Tuple<int, Model.Answer>> ansList = null;

        private bool checkConnect = false;
        private Thread listen = null;

        public frmLogin()
        {
            InitializeComponent();
        }


        #region -- Event --

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
            if (checkConnect) return;
            if (validate())
            {
                int size;
                sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    sck.Connect(IPAddress.Parse(txtIpServer.Text), Convert.ToInt32(txtPort.Text));
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.ToString(), "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sck.Close();
                    return;
                }

                this.Width = 620;
                btnClose.Location = new Point(290, 4);
                PanelTransition.ShowSync(panelProcess);
                checkConnect = true;

                try
                {
                    data = new byte[1024];

                    size = sck.Receive(data);//size server transfer

                    processBar.MaxValue = Convert.ToInt32(Encoding.ASCII.GetString(data, 0, size));

                    sendDone();

                    data = new byte[1024];
                    size = sck.Receive(data);//object para
                    Controller.ParaObject para = new Controller.ParaObject(data);
                    Controller.Constant.time = para.Time * 60;

                    processBar.Value += size;
                    processBar.Update();

                    sendDone();

                    if (para.GetDB > 0)
                    {
                        for (int i = 0; i < para.GetDB; i++)
                        {
                            data = new byte[1024];
                            size = sck.Receive(data);
                            Model.Question ques = new Model.Question(data);
                            lsquesDB.Add(ques);
                            processBar.Value += size;
                            processBar.Update();
                            sendDone();
                        }
                        size = sck.Receive(data);
                        int countAns = Convert.ToInt32(Encoding.ASCII.GetString(data, 0, size));
                        sendDone();

                        for (int i = 0; i < countAns; i++)
                        {
                            data = new byte[1024];
                            size = sck.Receive(data);
                            Model.Answer ans = new Model.Answer(data);
                            lsansDB.Add(ans);
                            processBar.Value += size;
                            processBar.Update();
                            sendDone();
                        }
                    }

                    if (para.GetFile > 0)
                    {
                        for (int i = 0; i < para.GetFile; i++)
                        {
                            data = new byte[1024];
                            size = sck.Receive(data);
                            Model.Question ques = new Model.Question(data);
                            lsquesFile.Add(ques);
                            processBar.Value += size;
                            processBar.Update();
                            sendDone();
                        }
                        size = sck.Receive(data);
                        int countAns = Convert.ToInt32(Encoding.ASCII.GetString(data, 0, size));
                        sendDone();

                        for (int i = 0; i < countAns; i++)
                        {
                            data = new byte[1024];
                            size = sck.Receive(data);
                            Model.Answer ans = new Model.Answer(data);
                            lsansFile.Add(ans);
                            processBar.Value += size;
                            processBar.Update();
                            sendDone();
                        }
                    }
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.ToString(), "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sck.Close();
                    return;
                }

                var ls = joinList();
                this.quesList = ls.Item1;
                this.ansList = ls.Item2;

                btnStartQuiz.Visible = true;

                listen = new Thread(new ThreadStart(threadListen));
                listen.IsBackground = true;
                listen.Start();
            }
            else
            {
                MessageBox.Show("Bạn phải điền đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmMain(quesList, ansList, txtCode.Text + " - " + txtName.Text + " - " + txtClass.Text)).ShowDialog();
        }

        #endregion


        #region -- Method --

        private void threadListen()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                try
                {
                    int size = sck.Receive(data);
                    string msg = Encoding.ASCII.GetString(data, 0, size);
                    if (msg == "SETTING;serverstop")
                    {
                        sck.Close();
                        break;
                    }
                }
                catch { return; }
            }
        }

        private Tuple<List<Tuple<int, Model.Question>>, List<Tuple<int, Model.Answer>>> joinList()
        {
            List<Tuple<int, Model.Question>> quesList = new List<Tuple<int, Model.Question>>();
            List<Tuple<int, Model.Answer>> answList = new List<Tuple<int, Model.Answer>>();
            int sttQues = 1;
            int sttAns = 1;

            foreach (var ques in lsquesDB)
            {
                quesList.Add(new Tuple<int, Model.Question>(sttQues, ques));
                sttQues++;
            }

            foreach (var ques in lsquesFile)
            {
                quesList.Add(new Tuple<int, Model.Question>(sttQues, ques));
                sttQues++;
            }

            foreach (var anw in lsansDB)
            {
                answList.Add(new Tuple<int, Model.Answer>(sttAns, anw));
                sttAns++;
            }

            foreach (var anw in lsansFile)
            {
                answList.Add(new Tuple<int, Model.Answer>(sttAns, anw));
                sttAns++;
            }

            return new Tuple<List<Tuple<int, Model.Question>>, List<Tuple<int, Model.Answer>>>(quesList, answList);
        }

        private void sendDone()
        {
            sck.Send(Encoding.ASCII.GetBytes("done"));
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
            if (sck != null)
                if (sck.Connected)
                {
                    sck.Send(Encoding.ASCII.GetBytes("disconnect"));
                    sck.Close();
                }
            if (listen != null) listen.Abort();
            Environment.Exit(0);
        }

        #endregion
    }
}

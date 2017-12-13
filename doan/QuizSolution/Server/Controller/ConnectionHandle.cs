using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Controller
{
    public class ConnectionHandle
    {
        private Socket sckClient;
        private static List<Socket> lsClient = new List<Socket>();
        private ObjectForThread para;//object chứa time
        private List<Model.Question> lsquesdb = null;
        private List<Model.Question> lsquesfile = null;
        private List<Model.Answer> lsansdb = null;
        private List<Model.Answer> lsansfile = null;
        private int sizeTransfer = 0;
        private int size = 0;
        private RichTextBox txtCmd;
        private bool stop = false;
        private Thread listen = null;


        /*
         * fix “cross-thread exception” 
         * vì cập nhật thuộc tính các đối tượng
         * giao diện đồ họa (như textbox, Button, ListBox,…)
         * của thread trong thread
         */
        delegate void richTXTChange(RichTextBox box, string text, Tuple<int, int, int> color);

        public ConnectionHandle(RichTextBox txtCmd)
        {
            this.txtCmd = txtCmd;
            stop = true;
        }

        public ConnectionHandle(Socket sckClient, RichTextBox txtCmd)
        {
            stop = false;
            this.sckClient = sckClient;
            this.txtCmd = txtCmd;

            para = getObjForConnectionHandel();
            sizeTransfer += getSizeByte(para.toByteArray());

            lsClient.Add(sckClient);

            if (para.GetDB != 0)
            {
                var random = getRandom("db", para.GetDB);
                lsquesdb = random.Item1;
                lsansdb = random.Item2;
                foreach (var ques in lsquesdb) sizeTransfer += getSizeByte(ques.toByteArray());
                foreach (var ans in lsansdb) sizeTransfer += getSizeByte(ans.toByteArray());
            }

            if (para.GetFile != 0)
            {
                var random = getRandom("file", para.GetFile);
                lsquesfile = random.Item1;
                lsansfile = random.Item2;
                foreach (var ques in lsquesfile) sizeTransfer += getSizeByte(ques.toByteArray());
                foreach (var ans in lsansfile) sizeTransfer += getSizeByte(ans.toByteArray());
            }
        }


        private void sendDone()
        {
            sckClient.Send(Encoding.ASCII.GetBytes("done"));
        }

        /// <summary>
        /// function thread call
        /// </summary>
        public void Run()
        {
            try
            {
                byte[] data = new byte[1024];

                sckClient.Send(Encoding.ASCII.GetBytes(sizeTransfer.ToString()));
                size = sckClient.Receive(data);

                sckClient.Send(para.toByteArray());
                size = sckClient.Receive(data);

                if (lsquesdb != null && lsquesdb.Count > 0)
                {
                    for (int i = 0; i < lsquesdb.Count; i++)
                    {
                        sckClient.Send(lsquesdb[i].toByteArray());
                        size = sckClient.Receive(data);
                    }
                    sckClient.Send(Encoding.ASCII.GetBytes(lsansdb.Count.ToString()));
                    size = sckClient.Receive(data);

                    for (int i = 0; i < lsansdb.Count; i++)
                    {
                        sckClient.Send(lsansdb[i].toByteArray());
                        size = sckClient.Receive(data);
                    }
                }

                if (lsquesfile != null && lsquesfile.Count > 0)
                {
                    for (int i = 0; i < lsquesfile.Count; i++)
                    {
                        sckClient.Send(lsquesfile[i].toByteArray());
                        size = sckClient.Receive(data);
                    }
                    sckClient.Send(Encoding.ASCII.GetBytes(lsansfile.Count.ToString()));
                    size = sckClient.Receive(data);

                    for (int i = 0; i < lsansfile.Count; i++)
                    {
                        sckClient.Send(lsansfile[i].toByteArray());
                        size = sckClient.Receive(data);
                    }
                }



                listen = new Thread(new ThreadStart(threadListen));
                listen.IsBackground = true;
                listen.Start();
            }
            catch
            {
                txtCmd.Invoke(new richTXTChange(AppendText), new object[] { txtCmd, sckClient.RemoteEndPoint + " disconnected", new Tuple<int, int, int>(255, 0, 0) });
                lsClient.Remove(sckClient);
                sckClient.Close();
            }
        }

        private Tuple<List<Model.Question>, List<Model.Answer>> getRandom(string type, int num_ques)
        {
            List<Model.Question> returnQues = new List<Model.Question>();
            List<Model.Answer> returnAns = new List<Model.Answer>();

            List<Model.Question> lsques = new List<Model.Question>();
            List<Model.Answer> lsans = new List<Model.Answer>();

            if (type == "db")
            {
                for (int i = 0; i < ListObj.LsQuesDB.Count; i++) lsques.Add(ListObj.LsQuesDB[i]);
                for (int i = 0; i < ListObj.LsAnsDB.Count; i++) lsans.Add(ListObj.LsAnsDB[i]);
            }
            else
            {
                for (int i = 0; i < ListObj.LsQuesFile.Count; i++) lsques.Add(ListObj.LsQuesFile[i]);
                for (int i = 0; i < ListObj.LsAnsFile.Count; i++) lsans.Add(ListObj.LsAnsFile[i]);
            }

            for (int i = 0; i < num_ques; i++)
            {
                var random = new Random();
                int index = random.Next(lsques.Count);
                Model.Question ques = lsques[index];
                for (int j = 0; j < lsans.Count; j++)
                {
                    if (lsans[j].Id_ques == ques.Id)
                    {
                        returnAns.Add(lsans[j]);
                    }
                }
                returnQues.Add(ques);
                lsques.Remove(ques);
            }

            txtCmd.Invoke(new richTXTChange(AppendText), new object[] { txtCmd, sckClient.RemoteEndPoint + " connected", new Tuple<int, int, int>(0, 128, 0) });

            return new Tuple<List<Model.Question>, List<Model.Answer>>(returnQues, returnAns);
        }

        private int getSizeByte(byte[] data)
        {
            return data.Length;
        }

        private Controller.ObjectForThread getObjForConnectionHandel()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path = Path.Combine(path, Controller.Constant.nameFolderSaveFile);
            path = Path.Combine(path, Controller.Constant.nameFileSetting);
            Controller.IO_INI ini = new Controller.IO_INI(path);
            string time = ini.IniReadValue(Controller.Constant.sectionSetting, Controller.Constant.keyTime);
            string numGetDB = "";
            string numGetFile = "";
            if (ini.IniReadValue(Controller.Constant.sectionDB, Controller.Constant.keyIdCourse) != string.Empty)
            {
                numGetDB = ini.IniReadValue(Controller.Constant.sectionDB, Controller.Constant.keyGetQuesDB);
            }
            if (ini.IniReadValue(Controller.Constant.sectionFile, Controller.Constant.keyPathFile) != string.Empty)
            {
                numGetFile = ini.IniReadValue(Controller.Constant.sectionFile, Controller.Constant.keyGetQuesFile);
            }
            if (numGetDB == string.Empty) numGetDB = "0";
            if (numGetFile == string.Empty) numGetFile = "0";
            var obj = new Controller.ObjectForThread(Convert.ToInt32(time), Convert.ToInt32(numGetDB), Convert.ToInt32(numGetFile));
            return obj;
        }

        //chạy nền kiểm tra câu lệnh
        private void threadListen()
        {
            while (!stop)
            {
                byte[] data = new byte[1024];
                try
                {
                    int size = sckClient.Receive(data);
                    string msg = Encoding.ASCII.GetString(data, 0, size);
                    if (msg == "disconnect")
                    {
                        txtCmd.Invoke(new richTXTChange(AppendText), new object[] { txtCmd, sckClient.RemoteEndPoint + " disconnected", new Tuple<int, int, int>(255, 0, 0) });
                        lsClient.Remove(sckClient);
                        sckClient.Close();
                        break;
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        private void AppendText(RichTextBox box, string text, Tuple<int, int, int> color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = box.TextLength;
            box.SelectionColor = Color.FromArgb(color.Item1, color.Item2, color.Item3);
            box.AppendText(text + "\r\n");
            box.SelectionColor = box.ForeColor;
        }

        public void stopServer(string str = null)
        {
            foreach (var sck in lsClient)
            {
                sck.Close();
            }

            if (str == null)
            {
                txtCmd.Invoke(new richTXTChange(AppendText), new object[] { txtCmd, "Server stop!", new Tuple<int, int, int>(255, 0, 0) });
            }

            lsClient.Clear();
            if (listen != null) listen.Abort();
        }
    }
}

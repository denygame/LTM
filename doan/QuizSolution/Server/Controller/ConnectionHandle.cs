using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Controller
{
    public class ConnectionHandle
    {
        private Socket sckClient;
        //private static List<Socket> lsClient = new List<Socket>();
        private ObjectForThread para;
        private List<Model.Question> lsquesdb = null;
        private List<Model.Question> lsquesfile = null;
        private List<Model.Answer> lsansdb = null;
        private List<Model.Answer> lsansfile = null;
        private int sizeTransfer = 0;
        private int size = 0;

        public ConnectionHandle(Socket sckClient)
        {
            this.sckClient = sckClient;

            para = getObjForConnectionHandel();
            sizeTransfer += getSizeByte(para.toByteArray());

            //lsClient.Add(sckClient);

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
                
            }
            catch
            {
                //lsClient.Remove(sckClient);
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
    }
}

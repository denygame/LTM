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
        private static List<Socket> lsClient = new List<Socket>();
        private ObjectForThread para;
        private List<Model.Question> lsquesdb = null;
        private List<Model.Question> lsquesfile = null;
        private List<Model.Answer> lsansdb = null;
        private List<Model.Answer> lsansfile = null;
        private int size = 0;

        public ConnectionHandle(Socket sckClient)
        {
            this.sckClient = sckClient;
            if (para == null)
            {
                para = getObjForConnectionHandel();
                size += getSizeByte(para.toByteArray());
            }
            lsClient.Add(sckClient);

            if (para.GetDB != 0)
            {
                var random = getRandom("db", para.GetDB);
                lsquesdb = random.Item1;
                lsansdb = random.Item2;
                foreach (var ques in lsquesdb) size += getSizeByte(ques.toByteArray());
                foreach (var ans in lsansdb) size += getSizeByte(ans.toByteArray());
            }

            if (para.GetFile != 0)
            {
                var random = getRandom("file", para.GetFile);
                lsquesfile = random.Item1;
                lsansfile = random.Item2;
                foreach (var ques in lsquesfile) size += getSizeByte(ques.toByteArray());
                foreach (var ans in lsansfile) size += getSizeByte(ans.toByteArray());
            }
        }

        public void Run()
        {
            byte[] data = new byte[1024];
            //sckClient.Send(Encoding.ASCII.GetBytes(size.ToString()));
            sckClient.Send(para.toByteArray());
            if (lsquesdb.Count > 0)
            {
                for (int i = 0; i < lsquesdb.Count; i++)
                {
                    sckClient.Send(lsquesdb[i].toByteArray());
                    int size = sckClient.Receive(data);
                    if (Encoding.ASCII.GetString(data, 0, size) == "done")
                    {
                        continue;
                    }
                }
            }

        }


        private Tuple<List<Model.Question>, List<Model.Answer>> getRandom(string type, int num_ques)
        {
            List<Model.Question> returnQues = new List<Model.Question>();
            List<Model.Answer> returnAns = new List<Model.Answer>();

            List<Model.Question> lsques;
            List<Model.Answer> lsans;

            if (type == "db")
            {
                lsques = ListObj.LsQuesDB;
                lsans = ListObj.LsAnsDB;
            }
            else
            {
                lsques = ListObj.LsQuesFile;
                lsans = ListObj.LsAnsFile;
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
                        lsans.Remove(lsans[j]);
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

        private int sizeCommand(int num)
        {
            int size = getSizeByte(Encoding.ASCII.GetBytes("answer?" + num));
            return size;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Model;

namespace Server.Controller
{
    /// <summary>
    /// save object to list
    /// setting with change
    /// </summary>
    class ListObj
    {
        private static List<Model.Question> lsQuesFile;
        private static List<Model.Answer> lsAnsFile;

        private static List<Model.Question> lsQuesDB;
        private static List<Model.Answer> lsAnsDB;

        public static List<Question> LsQuesFile { get => lsQuesFile; set => lsQuesFile = value; }
        public static List<Answer> LsAnsFile { get => lsAnsFile; set => lsAnsFile = value; }
        public static List<Answer> LsAnsDB { get => lsAnsDB; set => lsAnsDB = value; }
        public static List<Question> LsQuesDB { get => lsQuesDB; set => lsQuesDB = value; }

        public static void addWithFile(List<Model.Question> lsques, List<Model.Answer> lsans)
        {
            if (LsQuesFile == null)
            {
                LsQuesFile = new List<Model.Question>();
                LsAnsFile = new List<Model.Answer>();
            }

            foreach (var ques in lsques)
                LsQuesFile.Add(ques);
            foreach (var ans in lsans)
                LsAnsFile.Add(ans);

        }


        public static void deleteFile()
        {
            LsQuesFile = null;
            LsAnsFile = null;
        }


        public static void addWithDB(int id_course)
        {
            if (LsQuesDB == null)
            {
                LsQuesDB = new List<Question>();
                LsAnsDB = new List<Answer>();
            }
            else
            {
                LsQuesDB.Clear();
                LsAnsDB.Clear();
            }

            LsQuesDB = QuestionController.getListQues(id_course);
            foreach(var ques in LsQuesDB)
            {
                var ls = AnswerController.getAnswerList(ques.Id);
                foreach(var ans in ls)
                {
                    LsAnsDB.Add(ans);
                }
            }
        }

    }
}

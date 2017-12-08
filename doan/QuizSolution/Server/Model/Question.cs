using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    public class Question
    {
        private int id;
        private string content;
        private int id_course;
        private int num_answer_right;

        public int Num_answer_right { get => num_answer_right; set => num_answer_right = value; }
        public int Id_course { get => id_course; set => id_course = value; }
        public string Content { get => content; set => content = value; }
        public int Id { get => id; set => id = value; }

        public Question(DataRow r)
        {
            this.Num_answer_right = (int)r["num_answer_right"];
            this.Id_course = int.Parse(r["id_course"].ToString());
            this.Content = r["content"].ToString();
            this.Id = int.Parse(r["id"].ToString());
        }

        public Question(int id, string content, int num)
        {
            this.Id = id;
            this.Content = content;
            this.Num_answer_right = num;
        }
    }
}

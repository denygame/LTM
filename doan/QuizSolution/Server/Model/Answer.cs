using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    public class Answer
    {
        private int id;
        private string content;
        private int id_ques;
        private int true_or_false;

        public int True_or_false { get => true_or_false; set => true_or_false = value; }
        public int Id_ques { get => id_ques; set => id_ques = value; }
        public string Content { get => content; set => content = value; }
        public int Id { get => id; set => id = value; }

        public Answer(DataRow r)
        {
            this.True_or_false = (int)r["true_or_false"];
            this.Id_ques = int.Parse(r["id_ques"].ToString());
            this.Content = r["content"].ToString();
            this.Id = int.Parse(r["id"].ToString());
        }
    }
}

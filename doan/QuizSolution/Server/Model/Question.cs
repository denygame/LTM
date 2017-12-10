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

        /// <summary>
        /// int 4 byte
        /// string lenght còn lại
        /// </summary>
        /// <param name="data"></param>
        public Question(byte[] data)
        {
            Id = BitConverter.ToInt32(data, 0);
            Num_answer_right = BitConverter.ToInt32(data, 4);
            Content = Encoding.UTF8.GetString(data, 8, data.Length - 8);
        }

        public byte[] toByteArray()
        {
            List<byte> byteList = new List<byte>();
            byteList.AddRange(BitConverter.GetBytes(Id));
            byteList.AddRange(BitConverter.GetBytes(Num_answer_right));
            byteList.AddRange(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes(Content)));
            return byteList.ToArray();
        }
    }
}

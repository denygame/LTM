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

        public Answer(int id, string content, int id_ques, int true_or_false)
        {
            this.Id = id;
            this.Content = content;
            this.True_or_false = true_or_false;
            this.Id_ques = id_ques;
        }

        public Answer(string content, int id_ques, int true_or_false)
        {
            this.Content = content;
            this.True_or_false = true_or_false;
            this.Id_ques = id_ques;
        }

        /// <summary>
        /// int 4 byte
        /// string lenght còn lại
        /// </summary>
        /// <param name="data"></param>
        public Answer(byte[] data)
        {
            Id = BitConverter.ToInt32(data, 0);
            Id_ques = BitConverter.ToInt32(data, 4);
            True_or_false = BitConverter.ToInt32(data, 8);
            Content = Encoding.UTF8.GetString(data, 12, data.Length - 12);
        }

        public byte[] toByteArray()
        {
            List<byte> byteList = new List<byte>();
            byteList.AddRange(BitConverter.GetBytes(Id));
            byteList.AddRange(BitConverter.GetBytes(Id_ques));
            byteList.AddRange(BitConverter.GetBytes(True_or_false));
            byteList.AddRange(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes(Content)));
            return byteList.ToArray();
        }
    }
}

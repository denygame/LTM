using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    public class Course
    {
        private int id;
        private string name;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        public Course(DataRow r)
        {
            this.Name = r["name"].ToString();
            this.Id = Convert.ToInt32(r["id"]);
        }
    }
}

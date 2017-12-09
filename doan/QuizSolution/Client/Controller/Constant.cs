using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
    public class Constant
    {
        public static Tuple<int, int, int> colorHoverAnswer = new Tuple<int, int, int>(123, 104, 238);
        public static int time = -1;
        public static List<Model.Question> lsquesDB = new List<Model.Question>();
        public static List<Model.Question> lsquesFile = new List<Model.Question>();
        public static List<Model.Answer> lsansDB = new List<Model.Answer>();
        public static List<Model.Answer> lsansFile = new List<Model.Answer>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controller
{
    public class Constant
    {
        private static string mysql_server = "localhost";
        private static string mysql_db_name = "quiz";
        private static string mysql_port = "3306";
        private static string mysql_user = "root";

        public static string str_conn = "Server=" + mysql_server + ";Database=" + mysql_db_name + ";Port=" + mysql_port + ";User ID=" + mysql_user + ";Password=;charset = utf8";

        public static List<string> ls_cb_answers_dgv = new List<string>() { "True", "False" };
        public static int id_tag_new_row_add_dgv_answer = -1;

        public static string nameFolderSaveFile = "QuizSolutionData";
    }
}

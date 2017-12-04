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

        public static string str_conn = "Server=" + mysql_server + ";Database=" + mysql_db_name + ";Port=" + mysql_port + ";User ID=" + mysql_user + ";Password=";
    }
}

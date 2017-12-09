using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Controller
{
    public class Constant
    {
        public static string nameFileConnection = "connection.ini";
        public static string sectionConn = "Connection";
        public static string keyServerConn = "Server";
        public static string keyDBNameConn = "DatabaseName";
        public static string keyPortConn = "Port";
        public static string keyUserConn = "User";
        public static string keyPassConn = "Password";

        public static string mysql_server = "localhost";
        public static string mysql_db_name = "quiz";
        public static string mysql_port = "3306";
        public static string mysql_user = "root";
        

        public static List<string> ls_cb_answers_dgv = new List<string>() { "True", "False" };
        public static int id_tag_new_row_add_dgv_answer = -1;

        //setting file ini
        public static string nameFolderSaveFile = "QuizFolder";
        public static string nameFileSetting = "setting.ini";

        public static string sectionInfo = "Information";
        public static string keyIP = "IP";
        public static string keyPort = "Port";

        public static string sectionSetting = "Setting";
        public static string keyTime = "TimeOut";

        public static string sectionDB = "Database";
        public static string keyIdCourse = "Course";
        public static string keySelectedIndexCB = "CBSelectedIndex";
        public static string keyGetQuesDB = "Get";

        public static string sectionFile = "File";
        public static string keyPathFile = "Path";
        public static string keyGetQuesFile = "Get";


       
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Controller
{
    public class DBConnection
    {
        public static string getStrConn()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path = Path.Combine(path, Constant.nameFileConnection);

            if (!File.Exists(path))
            {
                IO_INI ini = new IO_INI(path);
                ini.IniWriteValue(Constant.sectionConn, Constant.keyServerConn, Constant.mysql_server);
                ini.IniWriteValue(Constant.sectionConn, Constant.keyDBNameConn, Constant.mysql_db_name);
                ini.IniWriteValue(Constant.sectionConn, Constant.keyPortConn, Constant.mysql_port);
                ini.IniWriteValue(Constant.sectionConn, Constant.keyUserConn, Constant.mysql_user);
                ini.IniWriteValue(Constant.sectionConn, Constant.keyPassConn, "");
            }

            IO_INI readIni = new IO_INI(path);
            string server = readIni.IniReadValue(Constant.sectionConn, Constant.keyServerConn);
            string dbName = readIni.IniReadValue(Constant.sectionConn, Constant.keyDBNameConn);
            string port = readIni.IniReadValue(Constant.sectionConn, Constant.keyPort);
            string user = readIni.IniReadValue(Constant.sectionConn, Constant.keyUserConn);
            string pass = readIni.IniReadValue(Constant.sectionConn, Constant.keyPassConn);

            return "Server=" + server + ";Database=" + dbName + ";Port=" + port + ";User ID=" + user + ";Password=" + pass + ";charset = utf8";
        }

        public static bool connect()
        {
            MySqlConnection conn = new MySqlConnection(getStrConn());
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

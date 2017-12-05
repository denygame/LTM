using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controller
{
    public class AnswerController
    {
        public static DataTable getListAnswer(int id_ques)
        {
            return DataProvider.sqlQuery("select id ,content, true_or_false from `answers` where id_ques = @id", new object[] { id_ques });
        }

        public static int get_last_id()
        {
            return Convert.ToInt32(DataProvider.sqlExecuteScalar("SELECT MAX(id) FROM `answers`"));
        }

        public static bool findId(int id)
        {
            int count = Convert.ToInt32(DataProvider.sqlExecuteScalar("SELECT Count(id) FROM `answers` where id = " + id));
            return count > 0;
        }

        public static bool delete(int id)
        {
            int result = DataProvider.sqlExecuteNonQuery("DELETE FROM `answers` WHERE id = @id", new object[] { id });
            return result > 0;
        }
    }
}

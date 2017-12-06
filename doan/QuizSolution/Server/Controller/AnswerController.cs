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

        public static bool insert(string content, int id_ques, int tf)
        {
            int result = DataProvider.sqlExecuteNonQuery("INSERT INTO `answers`( `content`, `id_ques`, `true_or_false`) VALUES ( @content , @idques , @tf )", new object[] { content, id_ques, tf });
            return result > 0;
        }

        public static bool update(Model.Answer ans)
        {
            int result = DataProvider.sqlExecuteNonQuery("UPDATE `answers` SET `content`= @content , `id_ques`= @id_ques , `true_or_false`= @tf WHERE `id` = @id ", new object[] { ans.Content, ans.Id_ques, ans.True_or_false, ans.Id });
            return result > 0;
        }

        public static bool deleteByIdQues(int idques)
        {
            int result = DataProvider.sqlExecuteNonQuery("DELETE FROM `answers` WHERE id_ques = @id", new object[] { idques });
            return result > 0;
        }
    }
}

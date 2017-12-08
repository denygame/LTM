using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controller
{
    public class QuestionController
    {
        public static DataTable getQuestionByIdCourse(int id)
        {
            return DataProvider.sqlQuery("select id, content, num_answer_right from `ques` where id_course = @id", new object[] { id });
        }

        public static Model.Question getQues(int id)
        {
            var data = DataProvider.sqlQuery("select * from `ques` where id = " + id);
            foreach (DataRow row in data.Rows)
                return new Model.Question(row);
            return null;
        }

        public static List<Model.Question> getListQues(int idCourse)
        {
            var ls = new List<Model.Question>();
            var data = DataProvider.sqlQuery("select * from `ques` where id_course = " + idCourse);
            foreach (DataRow row in data.Rows)
            {
                ls.Add(new Model.Question(row));
            }
            return ls;
        }

        public static bool delete(int id)
        {
            int result = DataProvider.sqlExecuteNonQuery("DELETE FROM `ques` WHERE id = @id", new object[] { id });
            return result > 0;
        }

        public static bool update(int id, string content, int num)
        {
            int result = DataProvider.sqlExecuteNonQuery("UPDATE `ques` SET `content`= @content ,  `num_answer_right` = @num WHERE id = @id", new object[] { content, num, id });
            return result > 0;
        }

        public static bool insert(string content, int id_course, int num)
        {
            int result = DataProvider.sqlExecuteNonQuery("INSERT INTO `ques`( `content`, `id_course`, `num_answer_right`) VALUES ( @content , @id_course , @num )", new object[] { content, id_course, num });
            return result > 0;
        }

        public static int get_last_id()
        {
            return Convert.ToInt32(DataProvider.sqlExecuteScalar("SELECT MAX(id) FROM `ques`"));
        }

        public static int countInCourse(int idcourse)
        {
            return Convert.ToInt32(DataProvider.sqlExecuteScalar("SELECT Count(*) FROM `ques` where id_course = " + idcourse));
        }

        public static List<int> getListIdInCourse(int idcourse)
        {
            var ls = new List<int>();
            var data = DataProvider.sqlQuery("Select id from `ques` where id_course = " + idcourse);
            foreach (DataRow row in data.Rows)
            {
                ls.Add(Convert.ToInt32(row["id"]));
            }
            return ls;
        }
    }
}

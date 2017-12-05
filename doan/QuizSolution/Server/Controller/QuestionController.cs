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
    }
}

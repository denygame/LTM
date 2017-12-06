using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controller
{
    public class CourseController
    {
        public static DataTable getCourses()
        {
            return DataProvider.sqlQuery("select * from `courses`");
        }

        public static int count()
        {
            return Convert.ToInt32(DataProvider.sqlExecuteScalar("SELECT Count(*) FROM `courses`"));
        }

        public static bool delete(int id)
        {
            int result = DataProvider.sqlExecuteNonQuery("DELETE FROM `courses` WHERE id = @id", new object[] { id });
            return result > 0;
        }

        public static Model.Course getCourseByid(int id)
        {
            var data = DataProvider.sqlQuery("select * from `courses` where id = " + id);
            foreach (DataRow row in data.Rows)
                return new Model.Course(row);
            return null;
        }

        public static int get_last_id()
        {
            return Convert.ToInt32(DataProvider.sqlExecuteScalar("SELECT MAX(id) FROM `courses`"));
        }


        public static bool update(int id, string name)
        {
            int result = DataProvider.sqlExecuteNonQuery("UPDATE `courses` SET `name`= @name WHERE id = @id", new object[] { name, id });
            return result > 0;
        }

        public static bool insert(int id, string name)
        {
            int result = DataProvider.sqlExecuteNonQuery("INSERT INTO `courses`(`id`,`name`) VALUES ( @id , @name )", new object[] { id, name });
            return result > 0;
        }

        public static List<Model.Course> getList()
        {
            var ls = new List<Model.Course>();
            var data = DataProvider.sqlQuery("Select * from `courses`");
            foreach (DataRow row in data.Rows)
            {
                ls.Add(new Model.Course(row));
            }
            return ls;
        }
    }
}

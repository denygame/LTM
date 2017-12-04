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
    }
}

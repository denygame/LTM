using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerUdp
{
    public class SimpleEnCode
    {
        public static string solution(int type, string str, int n)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                int value;
                if (type == 0)//ma hoa
                {
                   value  = (int)Convert.ToChar(str[i]) + n;
                }
                else//giai ma
                {
                    value = (int)Convert.ToChar(str[i]) - n;
                }
                char convert = (char)value;
                result += convert.ToString();
            }

            return result;
        }
    }
}

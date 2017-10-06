using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1451120025_XuLyChuoi
{
    public class Solution
    {
        public static string insertMSSV(string str)
        {
            return str.Insert(str.Length / 2, "1451120025");
        }

        // trả về tổng số từ và từ dài nhất
        public static Tuple<int, string> wordInString(string str)
        {
            var listSplit = str.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLength = 0;
            string maxWord = ""; //từ dài nhất
            foreach (var i in listSplit)
            {
                if (i.Length > maxLength)
                {
                    maxLength = i.Length;
                    maxWord = i;
                }
            }
            return new Tuple<int, string>(listSplit.Length, maxWord);
        }

        public static string sort(string str)
        {
            string result = "";
            var listWord = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(listWord);
            foreach (var i in listWord)
                result += i + " ";
            return result;
        }
    }
}

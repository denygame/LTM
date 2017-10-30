using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1451120025_XuLyChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            Console.WriteLine("\r\n1. Chuoi in hoa: " + s.ToUpper());

            Console.WriteLine("\r\n2. Chen MSSV vao giua: " + Solution.insertMSSV(s));

            int countWord = Solution.wordInString(s).Item1;
            Console.WriteLine("\r\n3. Tong so tu: " + countWord);

            string longestWord = Solution.wordInString(s).Item2;
            Console.WriteLine("\r\n4. Tu dai nhat: "+ longestWord);

            Console.WriteLine("\r\n5. Sap xep: " + Solution.sort(s));

            Console.ReadKey();
        }
    }
}

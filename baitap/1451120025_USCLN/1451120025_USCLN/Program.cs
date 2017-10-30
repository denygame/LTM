using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1451120025_USCLN
{
    class Program
    {
        static int uscln(int a, int b)
        {
            int kq = 0;
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            kq = a;
            return kq;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1451120025 - Nguyen Thanh Huy - Giai thuat tim USCLN\r\n");
            int a, b;
        nhapA:
            Console.Write("Nhap so a: ");
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\r\n");
                goto nhapA;
            }

        nhapB:
            Console.Write("Nhap so b: ");
            try
            {
                b = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\r\n");
                goto nhapB;
            }

            Console.WriteLine("\r\nUSCLN(" + a + "," + b + ") = " + uscln(a, b));
            Console.ReadKey();
        }


    }
}

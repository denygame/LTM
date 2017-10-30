using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1451120025_FileTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 0 de nhan file (Server), 1 de gui file (Client)!");
            string userInput;
            bool check;
            do
            {
                check = false;
                Console.Write("==> Nhap chuc nang: ");
                userInput = Console.ReadLine();
                if (userInput.Length == 1)
                    foreach (var i in userInput)
                        if (i == '0' || i == '1') check = true;
            } while (!check);

            FileTrans.solution(int.Parse(userInput));
        }
    }
}

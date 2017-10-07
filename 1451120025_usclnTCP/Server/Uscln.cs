using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Uscln
    {
        public static int solve(int a, int b)
        {
            while (a != b)
                if (a > b) a -= b;
                else b -= a;
            return a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace literalcharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar = -100;
            uint myUvar = 1000;
            long myLVar = 1500L;
            ulong myULVar = 1200LU;
            float myfVar = 12.2F;
            decimal myDVar = 1.5M;
            Console.WriteLine($"{myvar}, {myUvar}, {myLVar}, {myULVar}, {myfVar}, {myDVar}");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increment___decrement_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 7, myVar2 = 2;
            myVar1  /= myVar2; 
            //myVar1 *= myVar2; this operation means myVar1 = myVar1 * myVar2 
            //myVar1 /= myVar2; this operation means myVar1 = myVar1 / myVar2 
            // the same concept for plus and minus 
            Console.WriteLine("{0}", myVar1);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparison == , != , < , > , <= , >= 
            // Boolean Condition && , || 

            bool myResult;
            int Var1 = 9, Var2 = 11;
            // myResult = Var1 == 9 ; // this operations is for indicate if the operation is true or false
            // myResult = Var1 != 9;
            //myResult = Var1 <= 8; 

            myResult = (Var1 == 9) || (Var2 == 16);
            Console.WriteLine("{0}", myResult);
            Console.ReadKey();
        }
    }
}

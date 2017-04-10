using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_operund_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            float myvar = 10.5f; //name of this sentence is operand
            float myvar2 = 10.7f; // it's operund 2 

            float temp = myvar + myvar2; // this is expression and (+) is operator 

            //basic operator (+ - * / ) 
            // bitwise operator 
            // logical operator boolean ( true , false ) 

            // 1 - unary operand 
            // 2 - binary operands 
            // 3 - ternary operands

            Console.WriteLine("{0} {1} {2}" ,myvar ,myvar2, temp);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematical_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 7;
            int var2 = 3;

            int temp1 = var1 + var2;
            int temp2 = var1 - var2;
            int temp3 = var1 / var2;
            int temp4 = var1 * var2;
            int temp5 = var1 % var2;

            string str = "I am";
            string str2 = " smart";
            string temp6 = str + str2; 

            Console.WriteLine(" the result1 {0} the result2 {1} the result3 {2} the result4 {3} the result5 {4}", temp1, temp2, temp3, temp4, temp5);
            Console.WriteLine("{0}", temp6);
            Console.ReadKey();

            // lesson of basic operators 


        }
    }
}

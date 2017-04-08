using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_string_variable
{
    class Program
    {
        static void Main(string[] args)
            // '\ \\ \0 \a \b \n \r \t \v \f @&""
        {
            string mystring = @"if know learn c sharp course in "" the channel youtube "" , a to z for learning\0";
            string mystring2 = " but i dont inderstund";
            string mystring3 = mystring + mystring2;
             
            Console.WriteLine("{0}", mystring3);
            Console.ReadKey();
        }
    }
}

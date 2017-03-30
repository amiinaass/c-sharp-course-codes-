using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes_text
{
    class Program
    {
        static void Main(string[] args)
        {
            int charmin = char.MinValue;
            int charmax = char.MaxValue;

            char myvar = 'Z';
            int myvarvalue = 'Z';
            char myvarvalue2 = Convert.ToChar(90);
            Console.WriteLine("minchar = {0} maxchar = {1} my character = {2} my variable value = {3}  my conversion is = {4} "
                , charmin, charmax, myvar,myvarvalue, myvarvalue2);

            string myfirststring = ("this is my string variable");
            Console.WriteLine("Amine Assaddiki {0}", myfirststring);

            bool mybool = true;
            Console.WriteLine("my boolean value is {0}", mybool);
            Console.ReadKey();
        }
    }
}

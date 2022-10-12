using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class program1
    {

        public static void CompareString()
        {

            string str1 = "C#";
            string str2 = "C#";
            if (String.Compare(str1, str2) == 0)
            {

                Console.WriteLine("str1 and str2 are equal");
            }

            else {
                Console.WriteLine("str1 and str2 are not equal.");
            }
            Console.ReadLine();
        }

          
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class program3
    {
        public static void IndexMethod()
        {
            string str = "Naveena";
            int index1 = str.IndexOf('a');
            Console.WriteLine("The Index Value of character 'a' is " + index1);
            int index2 = str.IndexOf('n');
            Console.WriteLine("The Index Value of character 'n' is " + index2);
            Console.ReadLine();

        }
    }
}

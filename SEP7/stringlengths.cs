using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep7library
{
    public delegate void LengthDelegate();
    public delegate string Concat(string s1, string s2);
    public class stringlengths
    {
       
        public void  length()
        {
            string str = "Amit";

            Console.WriteLine("String: " + str);
            Console.WriteLine("String Length: " + str.Length);
            
            Console.ReadKey();
        }
    }
}

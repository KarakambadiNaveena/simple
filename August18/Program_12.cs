using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August18_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p = "";
            string r = "Nani";
            bool b1 = string.IsNullOrEmpty(p);
            Console.WriteLine(b1);
            bool b2 = string.IsNullOrEmpty(r);
            Console.WriteLine(b2);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep7library
{
    public delegate void SecondDelegate();
    public class Greeting
    {
        public void greet()
        {
            string str = "Anitha";

            Console.WriteLine("Hello " + str);
           

            Console.ReadKey();
        }

    }
}

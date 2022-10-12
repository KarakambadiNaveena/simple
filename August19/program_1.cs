using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August19_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int min;
            int max; 
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            
            if (a > b)
                max = a;
            else
                max = b;

            if (a < b)
                min = a;
            else
                min = b;
            Console.WriteLine("Minimum number = {0}", min);
            Console.WriteLine("Maximum number = {0}", max);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August23
{
    internal class Program
    {


        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

        public static void Main()
        {
            
            Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
            Console.ReadLine();
        }
    }
}
       
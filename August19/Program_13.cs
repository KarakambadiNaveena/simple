using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August19_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
          
            Console.WriteLine("Enter the integer value");
            i = Convert.ToInt32(Console.ReadLine());
            if(i==0)
            {
                Console.WriteLine("given number is zero");
            }
            else
            {
                Console.WriteLine("given number is not zero");

            }
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
               
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
              
            }
            
            if (i%10 == 0)
            {
                Console.WriteLine("given number is divisible by 10");
            }
            else
            {
                Console.WriteLine("given number is not divisible by 10");
            }


            if (i>100)
            {
                Console.WriteLine("Given number is greater than 100");
            }
            else
            {
                Console.WriteLine("Given number is smaller than 100");

            }
            Console.ReadLine();

        }
    }
}

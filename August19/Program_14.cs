using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace August19_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer value");
            int i = Convert.ToInt32(Console.ReadLine());

            
            switch (i)
            {
               

                case int n when (i== 0):
                    Console.WriteLine("Given number is zero");
                    break;
                case int n when (i %2==0):
                    Console.WriteLine("Given number is even");

                    break;
                case int n when (i % 10 == 0):
                    Console.WriteLine("Given number is multiple of 10");

                    break;
                case int n when (i >100):
                    Console.WriteLine("Given number is multiple of 10");

                    break;
            }
            Console.ReadLine();
                    }

            }
        
}

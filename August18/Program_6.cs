using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August18_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look older than {0} ", age);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace August19_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3,total;
            float per;
            string grade;
            Console.Write("enter the first subject marks : ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the second subject marks : ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the third subject marks : ");
            sub3= Convert.ToInt32(Console.ReadLine());

            total = sub1 + sub2 + sub3;
            per = total / 3.0f;
            if (per >60)
                grade="First";
            else
            if (per >=45 && per <=60)
                grade="second";

            else
                if (per < 45 && per >= 35)
                grade = "third";
            else
                grade = "Fail";

            Console.Write("Total Marks = {0}\nPercentage = {1}\n Grade = {2}\n", total, per, grade);
            Console.ReadLine();
        }
    }
}
    

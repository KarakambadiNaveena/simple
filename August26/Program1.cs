using newLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friday_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] S = { new Student(), new Student() };

            S[0].SetStudent(101, "Sam", 5000);
            S[1].SetStudent(102, "Nani", 8000);
            

            S[0].PrintStudent();
            S[1].PrintStudent();
            
            Console.ReadLine();
        }
    }
}
    


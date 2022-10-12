using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August23_3
{
    internal class Class1
    {
        internal class program
        {
            static void Main(string[] args)
            {
                Employee[] employees = new Employee[2];
                for (int i = 0; i < 2; i++)
                {

                    Console.WriteLine("Enter EmployeeNo");
                    int eNO = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name");
                    string name1 = Console.ReadLine();
                    
                    Console.WriteLine("Enter Salary : ");
                    double sal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter DeptNo:");
                    int deptNo = Convert.ToInt32(Console.ReadLine());
                    employees[i].AcceptData(eNO, name1, sal, deptNo);
                }
                for (int i = 0; i < 2; i++)
                {
                    employees[i].Display1();
                }
                Console.ReadLine();
            }
        }
    }
}

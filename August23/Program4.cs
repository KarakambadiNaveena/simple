using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace August23_3
{
    internal class Program
    {


    }
        struct Employee
        {
            public int empNo;
            public string ename;
            public double sal;
            public int deptNo;
            public void AcceptData(int empNo, string ename, double sal, int deptNo)
            {
                this.empNo = empNo;
                this.ename = ename;
                this.sal = sal;
                this.deptNo = deptNo;
            }
            public void Display1()
            {
                Console.WriteLine("EmployeeNo : {0} EmployeeName: {1} EmployeeSal: {2} EmployeeDeptNo : {3}   ", this.empNo, this.ename, this.sal, this.deptNo);
               
            }
        }
    }
        


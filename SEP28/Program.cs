using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_library;

namespace Sep28demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            studentoperations so = new studentoperations();
            BLL_class bal = new BLL_class();
            Console.WriteLine("Add Student");
            Console.WriteLine("enter student id");

            bal.studid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter student name");
            bal.name = Console.ReadLine();

            Console.WriteLine("enter course id");
            bal.crsid = Convert.ToInt32(Console.ReadLine());

            so.Insertstudent(bal);
            Console.WriteLine("record Inserted successfully...");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Update Student");
            Console.WriteLine("enter studentid to update");
            bal.studid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter student name");
            bal.name = Console.ReadLine();
            Console.WriteLine("enter courseid");
            bal.crsid= Convert.ToInt32(Console.ReadLine());
            so.Updatestudent(bal);
            Console.WriteLine("Updated successfully....");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Delete Student");
            Console.WriteLine("enter studentid to delete");
            bal.studid = Convert.ToInt32(Console.ReadLine());
            so.Deletestudent(bal);
            Console.WriteLine("Deleted successfully....");
            Console.WriteLine("--------------------------------------");
        }
    }
}

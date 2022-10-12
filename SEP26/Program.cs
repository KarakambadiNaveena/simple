using BAL;
using Helperlibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("--------------------------------");
            shopping_helper helper = new shopping_helper();
            shopping_BAL s =new shopping_BAL();
            Console.WriteLine("Enter bookno");
            s.Book_No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter bookname");
            s.Book_Name = Console.ReadLine().Trim();
            Console.WriteLine("Enter Author");
            s.Author = Console.ReadLine().Trim();
            Console.WriteLine("Enter Cost");
            s.Cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Category");
            s.Category = Console.ReadLine().Trim();
            


            bool queryStatus = helper.AddBook(s);
            if (queryStatus)
            {
                Console.WriteLine("Book added successfully.....");
            }
            else
            {
                Console.WriteLine("Some error occured...");
            }
            
            Console.ReadLine();
        }
    }
}

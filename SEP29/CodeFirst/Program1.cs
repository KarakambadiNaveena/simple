using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sep29library;

namespace sep29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            context.MemberTable.Add(new Member{ memberID = 1, memberName = "Sweety" });
            
            context.BookTable.Add(new Book{bookID = 1,bookName="Life",cost=150});
           
            context.IssuesTable.Add(new Issues { issueID = 1, bookID = 1, memberID = 1 });
            context.SaveChanges();

            Console.WriteLine("done");
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL_Library.DAL_class;

namespace code_sep29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            context.BorrowerTable.Add(new Borrower { borrowerid=1,borr_Name="sweety",city="kadapa",state="Ap",country="India" });

            context.LoanTable.Add(new Loan{ LoanId=1,LoanType="Houseloan" ,Amt=1000,duration=10,rateofintrest=2,});

           
            context.SaveChanges();

            Console.WriteLine("done");
            Console.Read();
        }
    }
}

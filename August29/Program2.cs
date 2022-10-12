using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace august29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserDataStore<string> stringdata = new UserDataStore<string>();
            stringdata.AddOrEdit(0, "Hello");
            string printdata = stringdata.ReturnData(0);
            Console.WriteLine(printdata);
            Console.WriteLine("-------------------");
            stringdata.AddOrEdit(0, "Welcome");
            stringdata.AddOrEdit(0, "Hi This is Naveena");
            stringdata.AddOrEdit(1, "example of generic classes");

            stringdata.ShowData(0);
            stringdata.ShowData(1);


            Console.ReadLine();

        }
    }
}

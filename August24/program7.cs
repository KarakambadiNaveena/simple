using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class program7
    {
        public static void Date()
        {
            
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            Console.WriteLine("Day=  " + dt.Day);
            Console.WriteLine("Month=  " + dt.Month);
            Console.WriteLine("Year=" + dt.Year);
            Console.WriteLine("Hour = " + dt.Hour);
            Console.WriteLine("Minute = " + dt.Minute);
            Console.WriteLine("Second = " + dt.Second);
            Console.WriteLine("Milliseconds " + dt.Millisecond);
            Console.WriteLine("Day of year " + dt.DayOfYear);
            Console.ReadLine();
            
        }
    }
}

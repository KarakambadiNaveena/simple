using Sep7library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Sep7
{
    public class Program
    {
        static void Main(string[] args)
        {
            stringlengths c = new stringlengths();
            LengthDelegate l = new LengthDelegate(c.length);
            l.Invoke();
            Greeting c2 = new Greeting();
            SecondDelegate s =new SecondDelegate(c2.greet);
            s.Invoke();
            Maths  m = new Maths();
            thirdDelegate[] t = new thirdDelegate[3] { m.Add, m.Sub, m.Mul };
            thirdDelegate k = (thirdDelegate)MulticastDelegate.Combine(t);
            k(50, 25);
            Product p1 = new Product() { Productid = 1, Productname = "Cake" };
            Product p2 = new Product() { Productid = 2, Productname = "Chocolate" };
            Product p3 = new Product() { Productid = 3, Productname = "Milkshake" };
            Product p4 = new Product() { Productid = 4, Productname = "sweet" };
            displayProduct p = new displayProduct(Product.Print);
            p(p1);
            p(p2);
            p(p3);
            p(p4);
            Employee e1 = new Employee() { joiningYear = 2020 };
            Employee e2 = new Employee() { joiningYear = 2010 };
            Employee e3 = new Employee() { joiningYear = 2021 };


            join j = delegate (Employee e) { return DateTime.Now.Year - e.joiningYear; };
            int emp1 = j(e1);
            Console.WriteLine("years of service : " + emp1);
            int emp2 = j(e2);
            Console.WriteLine("years of service : " + emp2);
            int emp3 = j(e3);
            Console.WriteLine("years of service : " + emp3);


            Concat z = delegate (string s1, string s2) { return s1 + s2; };
            Console.WriteLine(z("Naveena", "samantha"));

        }
    }
}

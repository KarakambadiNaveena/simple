using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sep5library;

namespace Sep5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(11, "Naveena", 2000, "Siri");
            Book b2 = new Book();
            b2.InsertBook("ABC", 100, 1000);
            Book b3 = new Book();
            b3.InsertBook("Rich Dad,Poor Dad", 1000, 550);
            Book b4 = new Book();
            b4.InsertBook("Magic", 1000, 500);
            Cart c1 = new Cart();
            c1.AddToCart(b1);
            c1.AddToCart(b2);
            c1.AddToCart(b3);
            c1.AddToCart(b4);
            c1.Display();
        }
    }
}

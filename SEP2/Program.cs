using categorydemo;
using productdemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pspk
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            product product1 = new product();
            product1.Productid = 1;
            product1.Productname = "book";
            product1.Price = 5;
            product1.Qtyinhand = 25;
            product1.Measure = 12;
            product1._Qtysold = 13;
            product1.Reorder = 1;
            Console.WriteLine(product1.Productid);
            Console.WriteLine(product1.Productname);
            Console.WriteLine(product1.Price);
            Console.WriteLine(product1.Qtyinhand);
            Console.WriteLine(product1.Measure);
            Console.WriteLine(product1.Reorder);
            Console.WriteLine(product1._Qtysold);

            product product2 = new product();
            product2.Productid = 2;
            product2.Productname = "pen";
            product2.Price = 10;
            product2.Qtyinhand = 4;
            product2.Measure = 12;
            product2._Qtysold = 33;
            product2.Reorder = 22;
            Console.WriteLine(product2.Productid);
            Console.WriteLine(product2.Productname);
            Console.WriteLine(product2.Price);
            Console.WriteLine(product2.Qtyinhand);
            Console.WriteLine(product2.Measure);
            Console.WriteLine(product2.Reorder);
            Console.WriteLine(product2._Qtysold);
            Category cate = new Category();
            cate.Catid = 1;
            cate.Catname = "rrr";
            cate.Description = "eeee";
            Console.WriteLine(cate.Catid);
            Console.WriteLine(cate.Catname);
            Console.WriteLine(cate.Description);








            //List<productlist> plist = new List<productlist();
            List<product> Catproducts = new List<product>();
            Catproducts.Add(product1);
            Catproducts.Add(product2);


        }


    }
}


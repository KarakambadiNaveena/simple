﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using productlibrary;

namespace August26_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> plist = new List<Products>(2);
           
           
           plist.Add(new Products { PID = 1, PName = "pen", Price = 10 });





            Products p1 = new Products();
            p1.PID = 2;
            p1.PName = "pencil";

            p1.Price = 20;

            plist.Add(p1);
            Products p2 = new Products();
            p2.PID = 3;
            p2.PName = "Book";
            p2.Price = 100;
            plist.Add(p2);
          


            foreach (var item in plist)
            {
                Console.WriteLine("PRODUCT ID:" + item.PID);
                Console.WriteLine("PRODUCT NAME:" + item.PName);
                Console.WriteLine("PRODUCT PRICE:" + item.Price);

            }
            plist.Remove(new Products { PID = 1, PName = "pen", Price = 10 });
            Console.WriteLine("Total products:"+plist.Count);
            plist.Remove(p1);
            Console.WriteLine("After removing the product");
            foreach (var item in plist)
            {
                Console.WriteLine("PRODUCT ID:"+item.PID);
                Console.WriteLine("PRODUCT NAME:"+item.PName);
                Console.WriteLine("PRODUCT PRICE:" + item.Price);

            }
            Console.WriteLine("After removing product count:"+plist.Count);
            //plist.Remove(new Products { PID = 1, PName = "Akhil", DeptNo = 10 });

            Console.WriteLine("removed successfully");


            Console.ReadLine();
        }
    }
}

    

        
   


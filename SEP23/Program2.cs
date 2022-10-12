using secondlibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep23_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = "Data Source=LAPTOP-1HSGU7I4\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True ";
            SqlConnection cn = new SqlConnection(connectionstring);
            // Console.WriteLine("enter the product id to search the product for: ");
            Class1 b1 = new Class1();

            // b1.ProductId= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the product name to search the product for: ");

            b1.ProductName = Console.ReadLine();
            // SqlCommand cmd = new SqlCommand("select * from Products where ProductId='" +b1.ProductId+ "'", cn);
            SqlCommand cmd = new SqlCommand("select * from v_products where ProductName='" + b1.ProductName + "'", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["ProductId"]);
                Console.WriteLine(dr["ProductName"]);
               
                Console.WriteLine(dr["UnitPrice"]);
                
                Console.WriteLine("================================");
            }

            Console.ReadLine();
            cn.Close();
        }
    }
}
    


        

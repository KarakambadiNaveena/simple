using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BAL;

namespace DAL
{
    public class shopping_DAL
    {
        public bool InsertBook(shopping_BAL Book)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingCnString"].ConnectionString);

            SqlCommand cmdInsert = new SqlCommand("insert into Book(Book_No,Book_Name,Author,Cost,Category) values(@Book_No,@Book_Name,@Author,@Cost,@Category)", cn);
            cmdInsert.Parameters.AddWithValue("@Book_No",Book.Book_No);
            cmdInsert.Parameters.AddWithValue("@Book_Name",Book.Book_Name);
            cmdInsert.Parameters.AddWithValue("@Author",Book.Author);
            cmdInsert.Parameters.AddWithValue("@Cost",Book.Cost);
            cmdInsert.Parameters.AddWithValue("@Category", Book.Category);
            cn.Open();
            int i = cmdInsert.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();
            cn.Dispose();
            return status;


        }


    }
}

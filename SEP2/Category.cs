using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using productdemo;

namespace categorydemo
{
    public class Category
    {

        public Category()
        {

        }
        public Category(int cid, string cname)
        {
            getCatid = cid;
            getCatname = cname;
        }
        public void AddCategory(int cid, string cname)
        {
            getCatId = cid;
            getCatName = cname;
            Console.WriteLine("Enter description : ");
            getDescription = Console.ReadLine();
        }
        public static int ProductCount = 0;
        List<Product> products = new List<Product>();
        public void AddItems(Product p)
        {
            products.Add(p);
            ProductCount++;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Category Name : " + this.getCatName);
            foreach (var item in products)
            {
                Console.WriteLine("Name : " + item.getPName + "\t" + "Uint Price : " + item.getUnitPrice);
            }
            Console.WriteLine("Product count : " + ProductCount);
            Console.WriteLine("======================================================");
        }

        private int _catid;

        public int Catid
        {
            get { return _catid; }
            set { _catid = value; }
        }
        private string _catname;


        public string Catname
        {
            get { return _catname; }
            set { _catname = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        /*private List<productlist> _plist;

        public List<Productlist> Plist
        {
            get { return _plist; }
            set { _plist = value; }
        }*/
        private List<product> _plist;

        public List<product> Plist
        {
            get { return _plist; }
            set { _plist = value; }
        }







    }
}
//}

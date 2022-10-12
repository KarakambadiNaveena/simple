using BAL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helperlibrary
{
    public class shopping_helper
    {
        shopping_DAL dal = null;
        public shopping_helper()
        {
            dal = new shopping_DAL();
        }


        public bool AddBook(shopping_BAL Book)
        {
            return dal.InsertBook(Book);

        }

    }
}

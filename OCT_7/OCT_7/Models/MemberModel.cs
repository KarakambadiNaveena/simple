using BusinessLogicLayerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OCT_7.Models
{
    public class MemberModel
    {
        private int _memberid;

        public int Member_Id
        {
            get { return _memberid; }
            set { _memberid = value; }
        }
        private string _membername;

        public string Member_Name
        {
            get { return _membername; }
            set { _membername = value; }
        }
        private DateTime _acc;

        public DateTime Acc_Open_Date
        {
            get { return _acc; }
            set { _acc = value; }
        }
        private int max_books;

        public int Max_Books_Allowed
        {
            get { return max_books; }
            set { max_books = value; }
        }
        private int _amt;

        public int Penalty_Amount
        {
            get { return _amt; }
            set { _amt = value; }
        }
    }
}
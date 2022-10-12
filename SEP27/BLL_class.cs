using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disconnected_BLL
{
    public class BLL_class
    {
        private int _studid;

        public int studid
        {
            get { return _studid; }
            set { _studid = value; }
        }

        private string _name;

        public string name
        {
            
            get { return _name; }
            set { _name = value; }
        }
        private int _crsid;

        public int crsid
        {
            get { return _crsid; }
            set { _crsid = value; }
        }
    }
}








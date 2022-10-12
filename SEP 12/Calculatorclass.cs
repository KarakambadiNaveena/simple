using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Class1
    {
        private double _i;

        public double i
        {
            get { return _i; }
            set { _i = value; }
        }

        public double sqrt(double i)
        {
            return i *i;
        }

        public double Cube(double i)
        {
            return i*i*i;
        }

    }
}

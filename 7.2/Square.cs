using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    internal class Square
    {
        int Side { get; set; }
        public Square() { }
        public Square(int side)
        {
            Side = side;
        }
        public double Area()
        { return Math.Round((double)Side * Side, 2); }
    }
}

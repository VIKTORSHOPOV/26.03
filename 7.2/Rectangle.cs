using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    internal class Rectangle
    {
        public double sideA { get; set; }
        public double sideB { get; set; }

        public Rectangle()
        {
            sideA = 0;
            sideB = 0;
        }
        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public double Area()
        {
            return Math.Round(sideA * sideB,2);
        }
    }
}

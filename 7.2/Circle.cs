using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    internal class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.Round(Radius * Radius * Math.PI,2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.Area());
            Rectangle rectangle1 = new Rectangle(5, 3);
            Console.WriteLine(rectangle1.Area());
            Console.WriteLine();
            Circle circle = new Circle();
            Console.WriteLine(circle.Area());
            Circle circle1 = new Circle(5);
            Console.WriteLine(circle1.Area());
            Console.WriteLine();
            Square square = new Square();
            Console.WriteLine(square.Area());
            Square square1 = new Square(5);
            Console.WriteLine(square1.Area());
        }
    }
}

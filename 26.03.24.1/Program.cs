using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._03._24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.Output();
            Dog dog2 = new Dog("Sharo", 4);
            dog2.Output();
        }
    }
}

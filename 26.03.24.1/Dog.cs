using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._03._24._1
{
    internal class Dog
    {
        string Name { get; set; }
        int Age { get; set; }
        public void Input()
        {
            Name = Console.ReadLine();
            Age = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
        }
        public Dog()
        {
            Name = "null";
            Age = 0;
        }
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

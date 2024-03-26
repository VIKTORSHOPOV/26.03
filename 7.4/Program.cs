using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Student me = new Student("Viktor", "Ivajlov", "Shopov", 22372123, "SCI", 1);
            Student student2 = new Student("Ivan", "Ivanov", "Ivanov");
            Student student3 = new Student("Petar", "Nikolov", "Georgiev", 2);
            Student.Info(student);
            Student.Info(me);
            Student.Info(student2);
            Student.Info(student3);

        }
    }
}

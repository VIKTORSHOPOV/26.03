using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time();
            time1.Output();
            Time time2 = new Time(12, 30, 5);
            time2.Output();

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    internal class Time
    {
        public int Seconds { get; set; }
        public int Minutes { get; set; }
        public int Hours { get; set; }

        public Time()
        {
            Seconds = 0;
            Minutes = 0;
            Hours = 0;
        }

        public Time(int seconds, int minutes, int hours)
        {
            Seconds = seconds;
            Minutes = minutes;
            Hours = hours;
        }

        public void Output()
        {
            Console.WriteLine($"{Hours:D2}:{Minutes:D2}:{Seconds:D2}");
        }




    }
}

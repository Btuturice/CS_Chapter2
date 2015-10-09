using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 90;
            int hours = minutes / 60;
            int minutes2 = minutes % 60;
            Console.WriteLine("{0} minutes is {1} hours and {2} minutes", minutes, hours, minutes2);
        }
    }
}

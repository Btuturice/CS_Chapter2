using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 25.0;
            double width = 42.0;
            double area = length * width / 9;

            double price = 2;
            double total = price * area;
            Console.WriteLine("The cost of carpeting is {0} dollars.", total.ToString("C"));
        }
    }
}

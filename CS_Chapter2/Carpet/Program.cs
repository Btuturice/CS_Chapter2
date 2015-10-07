using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 15.0;
            double width = 25.0;
            double area = length * width;
            double price = 2;
            double total = price * area;
            Console.WriteLine("The cost of carpeting is {0} dollars.", total);
        }
    }
}

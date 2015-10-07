using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleDecimalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double someMoney = 34.95;
            Console.WriteLine("The money is {0}", someMoney);
            decimal price = 999999999999.999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999m;
            Console.WriteLine(price);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs1 = 20;
            int eggs2 = 25;
            int eggs3 = 30;
            int eggs4 = 35;
            int total = eggs1 + eggs2 + eggs3 + eggs4;
            int dozon = total / 12;
            int eggs = total % 12;
            Console.WriteLine("dozons: {0} eggs: {1}", dozon, eggs);
        }
    }
}

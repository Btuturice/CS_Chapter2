using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Eggs from chicken 1:");
             int eggs1 = Convert.ToInt32(Console.ReadLine()); 
             Console.WriteLine("Eggs from chicken 2:");
             int eggs2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Eggs from chicken 3:");
             int eggs3 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Eggs from chicken 4:");
             int eggs4 = Convert.ToInt32(Console.ReadLine());

             int total = eggs1 + eggs2 + eggs3 + eggs4;

             int dozon = total / 12;

             int eggs = total % 12;

             Console.WriteLine("dozons: {0} eggs: {1}", dozon, eggs);
        }
    }
}

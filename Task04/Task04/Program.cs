using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int total = 1;
            int gg = 1;

            while (gg <= 10)
            {
                total *= gg;
                gg++;
            }

            Console.WriteLine("The Factorial of 10 is: " + (total));
            Console.ReadLine();
        }
    }
}

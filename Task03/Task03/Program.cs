using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int total = 0;

            int limit = 20;

            for (int start = 1; start <= limit; start++)
            {
                Console.WriteLine("Please Enter a Number");
                total = total + int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The Sum is: " + (total));
            Console.ReadLine();
            
        }
    }
}

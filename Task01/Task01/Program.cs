using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
       
            Console.WriteLine("Please Enter A letter I will tell you whether its a consonant or vowel");
            string letter = Console.ReadLine().ToLower();

            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
            {
                Console.WriteLine("This letter is a vowel");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This letter is a consonant");
                Console.ReadLine();
            }

        }
    }
}

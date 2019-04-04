using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
                                  
            Console.WriteLine("Please Enter Your Height in CM's");
            float height = float.Parse(Console.ReadLine())/100;

            Console.WriteLine("Please Enter Your Weight in KG's");
            float weight = float.Parse(Console.ReadLine());

            float BMI = weight / (height * height);

            Console.WriteLine("This is your BMI: " + BMI);
            Console.ReadLine();


        }
    }
}

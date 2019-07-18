using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int number1 = Convert.ToInt32(args[0]);
            //    int number2 = Convert.ToInt32(args[1]);

            //    if(number1 >0 && number1 < 0)
            //    {
            //        Console.WriteLine("True");
            //    }

            //    else if (number1 < 0 && number1 > 0)
            //    {
            //        Console.WriteLine("True");
            //    }

            //    else
            //    {
            //        Console.WriteLine("False");
            //    }

            //    Console.ReadLine();

            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
            Console.ReadLine();
        }
    }
}

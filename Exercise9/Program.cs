using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            decimal firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            decimal secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            decimal thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number:");
            decimal fourthNumber = int.Parse(Console.ReadLine());

            decimal average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", firstNumber,secondNumber,
                thirdNumber,fourthNumber,average);

            Console.ReadLine();
        }
    }
}

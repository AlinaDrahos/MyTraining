using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number to multiply: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number to multiply: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the third number to multiply: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int output = firstNumber * secondNumber * thirdNumber;

            Console.WriteLine("Output: {0}x {1}x {2}={3}",
                firstNumber, secondNumber, thirdNumber, output);
            Console.ReadLine();
        }
    }
}

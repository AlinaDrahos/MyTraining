using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your first number:");
            decimal firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input your second number:");
            decimal secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1}= {2}", firstNumber,secondNumber,firstNumber+secondNumber);
            Console.WriteLine("{0} - {1}= {2}", firstNumber, secondNumber, firstNumber-secondNumber);
            Console.WriteLine("{0} * {1}= {2}", firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine("{0} / {1}= {2}", firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("{0} mod {1}= {2} ", firstNumber,secondNumber, firstNumber%secondNumber);

            Console.ReadLine();

        }
    }
}

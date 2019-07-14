using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me your first number:");
            int firstNumber= int.Parse(Console.ReadLine());
            Console.WriteLine("Please give me your second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            int temp;
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine("First Number:{0}\nSecond Number {1} " ,firstNumber,secondNumber);
            Console.ReadLine();
        }
    }
}

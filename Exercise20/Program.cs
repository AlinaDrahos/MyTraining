using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two Numbers:..");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(AbsoluteValue(Num1, Num2));
            Console.ReadLine();
        }

        public static int AbsoluteValue(int numberOne, int numberTwo)
        {
            int result;
            result =Math.Abs(numberOne - numberTwo);
            if (numberOne>numberTwo)
            {
                result *=2;
            }
            return result;
        }
    }
}

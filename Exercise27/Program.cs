using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise27
{
    class Program
    {
        static List<int> myNumbers = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number...");
            int number = Convert.ToInt32(Console.ReadLine());
            List <int> mySum=MyNumbers(number);
            Console.WriteLine(Sum(mySum));
            Console.ReadLine();
        }

        public static List<int> MyNumbers(int number)
        {
            if (number < 10)
            {
                myNumbers.Add(number);
            }

            else
            {
                int b = number % 10;
                myNumbers.Add(b);
                MyNumbers((number - b)/10);
            }

            return myNumbers;
        }

        private static int Sum(List<int> Numbers)
        {
            int Sum = 0;
            foreach (int item in Numbers)
            {
                Sum +=item;
            }

            return Sum;
        }
    }
}

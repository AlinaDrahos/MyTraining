using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number:");
            int i = Convert.ToInt32(Console.ReadLine());
            Range(i);
            Console.ReadLine();
        }

        private static void Range(int number)
        {
                Console.WriteLine(Math.Abs(100 - number) <= 20 || Math.Abs(200 - number) <= 20);
        }
    }
}

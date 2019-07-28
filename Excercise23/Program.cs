using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a word, and I will convert it:");
            string myString = Console.ReadLine();
            WordConverter(myString);
            Console.ReadLine();
        }

        private static void WordConverter(string myWord)
        {
            Console.WriteLine(myWord.ToLower());
        }
    }
}

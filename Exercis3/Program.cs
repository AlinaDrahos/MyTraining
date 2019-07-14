using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal i = Int32.Parse(Console.ReadLine());
            decimal j = Int32.Parse(Console.ReadLine());
            decimal k = i /j;
            Console.WriteLine("The value of the division is: {0} ", k);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2
            int i = Int32.Parse((Console.ReadLine()));
            int j = Int32.Parse((Console.ReadLine()));
            int c = i + j;
            Console.WriteLine("The sum of both numbers is: {0}", c);
            Console.ReadLine();
        }
    }
}

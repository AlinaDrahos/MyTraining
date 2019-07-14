using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number : ");
            int j = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",j,i, j*i);

            }

            Console.ReadLine();
        }
    }
}

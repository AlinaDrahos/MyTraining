using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args[0]);
            int y = Convert.ToInt32(args[1]);
            int z = Convert.ToInt32(args[2]);

            Console.WriteLine("Results of specified numbers {0}, {1} and {2},(x+y)*z is {3} " +
                "and x*y+y*z is {4} ", x,y,z,(x+y)*z,x*y+y*z);
            Console.ReadLine();
        }
    }
}

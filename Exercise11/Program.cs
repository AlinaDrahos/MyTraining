using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            for (int j = 0; j < 4; j++)
            {
                if ((j % 2) != 0)
                {
                    string g= i.ToString();
                    Console.WriteLine(g+g+g+g);
                }
                if ((j % 2) == 0)
                {
                    string g = i.ToString();
                    Console.WriteLine(g +" "+ g +" " + g+ " " + g);
                }
            }
            Console.ReadLine();
        }
    }
}

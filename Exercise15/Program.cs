using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static string word;
        //static int index1;
        //static int index2;
        //static int index3;

        static void Main(string[] args)
        {
            word = args[0];
            //index1 = int.Parse(args[1]);
            //index2 = int.Parse(args[2]);
            //index3 = int.Parse(args[3]);

            //Method(index1);
            //Method(index2);
            //Method(index3);
            for (int i = 1; i < args.Length; i++)
            {
                int index = Convert.ToInt32(args[i]);
                Method(index);
            }

            Console.ReadLine();
        }

        private static void Method(int myIndex)
        {
            string newString=null;
            char[] myword = word.ToCharArray();
            for (int i = 0; i < myword.Length; i++)
            {
                if (i != myIndex)
                {
                    newString += myword[i];
                }
            }
            Console.WriteLine(newString);
        }
    }
}

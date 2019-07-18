using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = args[0].ToCharArray();
            char firstLetter = characters[0];

            string entireSentence = firstLetter.ToString() + new string (characters)+ firstLetter.ToString();
            Console.WriteLine(entireSentence);
            Console.ReadLine();
            /*string str;
             * int l=0;
             * Console.Write("Input a string : ");
             * str =Console.ReadLine();
             * if(str.Length >=1)
             * {
             *  var s =str.Substring(0,1);
             *  Console.WriteLine(s+str+s);*/
            //StringBuilder stringBuilder = new StringBuilder();
            //var stringBuilder2 = new StringBuilder();
        }
    }
}

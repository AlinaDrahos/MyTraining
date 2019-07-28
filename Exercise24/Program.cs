using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a sentence and leave spaces between the word!");
            string mySentence = Console.ReadLine();
            MyWordSeeker(mySentence);
            Console.ReadLine();

        }

        private static void MyWordSeeker(string word)
        {
            string longestWord = string.Empty;
            string[] mySentence = word.Split(' ');
            foreach (String item in mySentence)
            {
                if (item.Length> longestWord.Length)
                {
                    longestWord = item;
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}

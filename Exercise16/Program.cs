using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                string word = args[i];
                Method(word);
            }
        }

        public static void Method(string myWord)
        {
            string newWord = null;
            string firstLetter = null;
            string lastLetter = null;
            for (int i = 0; i < myWord.Length; i++)
            {
                firstLetter = myWord[0].ToString();
                lastLetter = myWord[(myWord.Length) - 1].ToString();
                if (i!=0 && i!=(myWord.Length-1) )
                {
                    newWord += myWord[i];
                }
            }

            newWord = lastLetter + newWord + firstLetter;
            Console.WriteLine(newWord);
            Console.ReadLine();
        }
    }
}

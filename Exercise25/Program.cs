using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allPrimes=MyPrimeNumbers();
            Console.WriteLine(PrimeSum(allPrimes));
            Console.ReadLine();
        }
        private static int[] MyPrimeNumbers()
        {
            int i = 2;
            int j = 0;
            int[] myPrimeNumbers = new int[500];
            do
            {
                if (IsNumberPrime(i))
                {
                    myPrimeNumbers[j] = i;
                    j++;
                }
                i++;
            }
            while (j<=499);

            return myPrimeNumbers;
        }

        private static bool IsNumberPrime(int numberToCheck)
        {
            for (int i = numberToCheck-1; i >= 2; i--)
            {
                if (numberToCheck%i==0)
                {
                    return false;
                }
            }

            return true;
        }

        private static int PrimeSum(int[] allPrimes)
        {
            int sum = 0;
            foreach (int item in allPrimes)
            {
                sum += item;
            }
            return sum;
        }
    }
}

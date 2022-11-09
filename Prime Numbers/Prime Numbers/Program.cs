using System;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPrimeNumber(2, 100);
        }

        public static void FindPrimeNumber(int startNumber, int endNumber)
        {
            Console.Write("Prime Number: ");
            for(int i = startNumber; i < endNumber; i++)
            {
                bool isPrime = true;
                for(int j = 2; j <= i / 2; j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine();
        }
    }
}

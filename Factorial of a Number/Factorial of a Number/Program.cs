using System;

namespace Factorial_of_a_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = FindFactorial(4);
            Console.WriteLine($"Factorial is: {result}");
        }

        public static int FindFactorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            return FindFactorial(number - 1) * number;
        }
    }
}

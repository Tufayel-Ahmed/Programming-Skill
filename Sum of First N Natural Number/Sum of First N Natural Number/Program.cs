using System;

namespace Sum_of_First_N_Natural_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(4);
            Console.WriteLine($"Sum = {result}");
        }

        public static int Sum(int number)
        {
            if(number <= 0)
            {
                return 0;
            }
            return Sum(number - 1) + number;
        }
    }
}

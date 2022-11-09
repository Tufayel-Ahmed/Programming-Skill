using System;

namespace Sum_of_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindSum(1234);
        }

        public static void FindSum(int number)
        {
            int reminder;
            int sum = 0;
            while (number > 0)
            {
                reminder = number % 10;
                sum = sum + reminder;
                number = number / 10;
            }
            Console.WriteLine($"Sum of Digits: {sum}");
        }
    }
}

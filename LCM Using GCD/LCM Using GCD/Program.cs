using System;

namespace LCM_Using_GCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = GCD(num1, num2);
            Console.WriteLine($"LCD is: {(num1 * num2) / result}");
        }

        public static int GCD(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            }
            return GCD(num2, num1 % num2);
        }
    }
}

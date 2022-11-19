using System;

namespace LCM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = LCM(num1, num2);
            Console.WriteLine($"LCD is: {result}");
        }

        public static int LCM(int num1, int num2)
        {
            int max = Math.Max(num1, num2);

            while (true)
            {
                if((max % num1 == 0) && (max % num2 == 0))
                {
                    break;
                }
                max++;
            }

            return max;
        }
    }
}

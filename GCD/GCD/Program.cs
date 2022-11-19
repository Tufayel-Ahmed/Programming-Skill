using System;

namespace GCD
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
            Console.WriteLine($"GCD is: {result}");
        }

        public static int GCD(int num1, int num2)
        {
            int v = 1;
            for(int i = Math.Min(num1, num2); i >= 2; i--)
            {
                if(num1 % i == 0 && num2 % i == 0)
                {
                    v = i;
                    break;
                }
            }
            return v;
        }
    }
}

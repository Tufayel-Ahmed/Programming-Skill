using System;

namespace SubtracttheProductandSumofDigitsofanInteger
{
    class Program
    {
        public static void Main(String[] args)
        {
            int n = 20;

            Solution solution = new Solution();
            int result = solution.SubtractProductAndSum(n);
            Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public int SubtractProductAndSum(int n)
        {
            int sum = 0, product = 1;
            while (n != 0)
            {
                sum += (n % 10);
                product *= (n % 10);
                n = n / 10;
            }
            return (product - sum);
        }
    }
}

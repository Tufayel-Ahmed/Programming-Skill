using System;

namespace _2235
{
    public class Solution
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();

            int result = solution.Sum(10, 20);

            Console.WriteLine(result);
        }
    }
}
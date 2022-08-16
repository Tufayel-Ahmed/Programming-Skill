using System;

namespace _412
{
    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();
            solution.FizzBuzz(10);
        }
    }
    public class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> list = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                bool divisibleBy3 = i % 3 == 0;
                bool divisibleBy5 = i % 5 == 0;

                if (divisibleBy3 && divisibleBy5)
                {
                    list.Add("FizzBuzz");
                }
                else if (divisibleBy5)
                {
                    list.Add("Buzz");
                }
                else if (divisibleBy3)
                {
                    list.Add("Fizz");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }
            return list;
        }
    }
}

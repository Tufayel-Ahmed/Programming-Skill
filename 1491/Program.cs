using System;

namespace _1491
{
    public class Solution
    {
        public double Average(int[] salary)
        {
            Array.Sort(salary);
            int sum = 0;
            for (int i = 1; i < salary.Length - 1; i++)
            {
                sum = sum + salary[i];
            }
            return (double)sum / (salary.Length - 2);
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();

            int[] salary = { 2356, 5646, 354644, 634964, 66, 664 };

            double result = solution.Average(salary);

            Console.WriteLine(result);
        }
    }
}
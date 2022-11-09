using System;

namespace Fibonacci_Series_using_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci Series: ");
            FindFibonacciSeries(0, 1, 1, 10);
        }

        public static void FindFibonacciSeries(int firstNumber, int secondNumber, int counter, int number)
        {
            Console.Write($"{firstNumber}, ");
            if(counter < number)
            {
                FindFibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, number);
            }
        }
    }
}

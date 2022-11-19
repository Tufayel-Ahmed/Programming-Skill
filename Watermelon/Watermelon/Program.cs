using System;

namespace Watermelon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = Convert.ToInt32(Console.ReadLine());

            if(w == 2 || w % 2 != 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}

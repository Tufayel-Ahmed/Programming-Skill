using System;

namespace Way_Too_Long_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                if (str.Length <= 10)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine($"{str[0]}{str.Length - 2}{str[str.Length - 1]}");
                }
            }
            
        }
    }
}

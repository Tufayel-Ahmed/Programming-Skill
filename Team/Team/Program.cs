using System;
using System.Threading;

namespace Team
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int count = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int p = Convert.ToInt32(Console.ReadLine());
                int v = Convert.ToInt32(Console.ReadLine());
                int t = Convert.ToInt32(Console.ReadLine());
                if((p + v + t) > 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

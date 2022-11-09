using System;
using System.Text;

namespace Find_All_Substrings_of_a_Given_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindSubstring("ABC");
        }

        public static void FindSubstring(string str)
        {
            Console.Write("Substrings: ");
            for(int i = 0; i < str.Length; i++)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for(int j = i; j < str.Length; j++)
                {
                    subString.Append(str[j]);
                    Console.Write($"{subString} ");
                }
            }
        }
    }
}

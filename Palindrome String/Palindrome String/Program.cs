using System;

namespace Palindrome_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindPalindromeString("madam");
        }

        public static void FindPalindromeString(string str)
        {
            string reverseString = String.Empty;
            for(int i = str.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + str[i];
            }
            if(str == reverseString)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }
        }
    }
}

using System;

namespace Palindrome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPalindrome(555);
        }

        public static void CheckPalindrome(int number)
        {
            int num = number;
            int reminder;
            int reverseNumber = 0;
            for(int i = 0; i < number; i++)
            {
                reminder = number % 10;
                reverseNumber = (reverseNumber * 10) + reminder;
                number = number / 10;
            }

            if(num == reverseNumber)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }
        }
    }
}

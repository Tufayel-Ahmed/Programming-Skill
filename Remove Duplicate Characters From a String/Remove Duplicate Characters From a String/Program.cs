using System;

namespace Remove_Duplicate_Characters_From_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicate("Hello World!");
        }

        public static void RemoveDuplicate(string str)
        {
            string resultString = String.Empty;
            for(int i = 0; i < str.Length; i++)
            {
                if (!resultString.Contains(str[i]))
                {
                    resultString = resultString + str[i];
                }
            }
            Console.WriteLine(resultString);
        }
    }
}

using System;

namespace Character_Occurrence_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            FindOccurrence("Hello World!");
        }

        public static void FindOccurrence(string str)
        {
            str = str.Replace(" ", string.Empty);
            while(str.Length > 0)
            {
                Console.Write($"{str[0]}: ");
                int count = 0;
                for(int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
        }
    }
}

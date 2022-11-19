using System;

namespace Remove_Duplicate_Elements_from_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 3, 4, 1, 6, 7, 9, 2, 3, 9};
            RemoveDuplicate(array);
        }

        public static void RemoveDuplicate(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }
                    if(array[i] == array[j])
                    {
                        break;
                    }
                }
            }
        }
    }
}

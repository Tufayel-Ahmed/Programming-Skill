using System;

namespace _383
{
    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();
            bool result = solution.CanConstruct("aa", "aab");
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {

            if (ransomNote.Length > magazine.Length)
            {
                return false;
            }
            foreach (char c in magazine)
            {
                int index = ransomNote.IndexOf(c);

                if (index == -1)
                {
                    continue;
                }
                ransomNote = ransomNote.Remove(index, 1);

                if (ransomNote.Length == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
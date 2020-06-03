using System;
using System.Collections.Generic;

namespace LongestSubstringWithNoRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
        }
        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int n = s.Length;
            int sub = 0, start = 0, end = 0;
            while (start < n && end < n)
            {
                if (!set.Contains(s[end]))
                {
                    set.Add(s[end++]);
                    sub = Math.Max(sub, end - start);
                }
                else
                {
                    set.Remove(s[start++]);
                }
            }
            return sub;
        }
    }
}

using System;

namespace SubString
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(findPalindrome("abcracecars"));
        }
        //Find the if a sting is a palindrome
        public static bool IsPalindrome(string str)
        {
            string reverse = "";
            for (int i = str.Length-1; i >=0; i--)
            {
                reverse += str[i];
            }
            if (str == reverse)
            {
                return true;
            }
            return false;

        }
        //The longest palindrom in a substring
        public static string findPalindrome(string s)
        {
            string substr = "";
            string LongestPalindrome = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - i; j++)
                {
                    substr=s.Substring(i, j + 1);
                    Console.WriteLine(substr);
                    if (IsPalindrome(substr))
                    {
                        if (substr.Length > LongestPalindrome.Length)
                        {
                            LongestPalindrome = substr;
                        }
                    }
                }
            }
           
            return LongestPalindrome;
        }
    }
}

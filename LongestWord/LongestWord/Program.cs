using System;
using System.Text;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to find the Longest word");
            string sen = Console.ReadLine();
            Console.WriteLine(LongestWord(sen));

        }
        public static string LongestWord(string sen)
        {

            // code goes here  
            string[] str = sen.Split(' ');
            foreach(string w in str)
            {
                Console.WriteLine(w);
            }        
            string Longest = "";
            foreach (string word in str)
            {
                string sb = NoPunctuation(word);
                if (sb.Length > Longest.Length)
                {
                    Longest = sb;
                }
            }
            return Longest;
        }
        public static string NoPunctuation(string words)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char word in words)
            {
                if (!char.IsPunctuation(word))
                {
                    sb.Append(word);
                }
            }
            return sb.ToString();
        }
    }
}

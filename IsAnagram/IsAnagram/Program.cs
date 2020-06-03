using System;
using System.Security.Cryptography;

namespace IsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receive input from the user
            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();

            //convert to lower and to array
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            //sort them
            Array.Sort(char1);
            Array.Sort(char2);

            //Create two strings out of the two sorted character set arrays.
            string newWord1 = new string(char1);
            string newWord2 = new string(char2);

            //compare the strings
            if (newWord1==newWord2)
            {
                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
            }
            Console.ReadLine();
        }
    }
}

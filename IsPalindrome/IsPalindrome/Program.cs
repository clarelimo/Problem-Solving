using System;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to check if its a palindrome");
            string name = Console.ReadLine();
            string reverse = "";
            for (int i = name.Length-1; i >=0; i--)
            {
                reverse += name[i];
            }
            Console.WriteLine(reverse);
            if (name==reverse)
            {
                Console.WriteLine(  "The string is a palindrom!");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome!");
            }

          
        }
    }
}

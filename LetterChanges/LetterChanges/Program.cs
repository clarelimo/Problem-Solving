using System;
using System.Text;

namespace LetterChanges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String to change");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the shifts to make");
            int shift = int.Parse(Console.ReadLine());
            Console.WriteLine(LetterChanges(str, shift));
        }
        public static string LetterChanges(string str ,int shift)
        {
            
            var sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char letter = str[i];
                if (char.IsLetter(letter))
                {
                    var NextLetter = (char)(letter + shift);
                    sb.Append(NextLetter);
                }
                else
                {
                    sb.Append(letter);
                }
                
            }
            str = sb.ToString();
            return str;
        }
    }
}

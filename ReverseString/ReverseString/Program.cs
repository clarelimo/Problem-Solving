using System;
using System.Collections;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
           
           // ReverseString();
            //StringReverse();
            // ReverseWord();
            char[] c = { 'h', 'e', 'l', 'l', 'o'};
            ReversedString(c); 
        }
        public static void ReverseStack()
        {
            Console.WriteLine("Enter the string to sreverse");
            string str1 = Console.ReadLine();

            Stack mystack = new Stack();
            for (int i = 0; i < mystack.Count; i++)
            {
                mystack.Push(i);
            }
            for (int i = 0; i < mystack.Count; i++)
            {
                mystack.Peek();
                mystack.Pop();
            }
        }
        public static void ReverseString()
        {
            string[] s = "i like this program very much".Split(' ');
            string ans = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans += s[i] + " ";
            }
            Console.Write("Reversed String:\n");
            Console.Write(ans.Substring(0, ans.Length - 1));
        }
        public static void ReverseWord()
        {
            Console.Write("Enter the string : ");
            string originalString = Console.ReadLine();

            string reverseWordString = string.Join(" ", originalString
            .Split(' ')
            .Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine($"Reversed String : {reverseWordString}");
            Console.ReadKey();
        }
        public static void StringReverse()
        {
            Console.WriteLine("Enter the string to reverse:");
            string OriginalString = Console.ReadLine();
            int start = 0;
            string ReversedString = "";
            for (int i = OriginalString.Length-1;  i>=0; i--)
            {
                //if (char.IsLetterOrDigit(OriginalString[i]))
                //{
                    ReversedString += OriginalString[i];
                //}else if (!char.IsLetterOrDigit(OriginalString[start]))
                //{
                //    ReversedString += OriginalString[start];
                //    start++;
                //}
                                  
            }
            Console.WriteLine($"Reversed String: {ReversedString}");
            Console.ReadKey();
        }
        public static void ReversedString(char[] c)
        {
            int left = 0;
            int right = c.Length - 1;
            while (left < right)
            {
                char temp = c[left];
                c[left++] = c[right];
                c[right--] = temp;
            }
            Console.WriteLine(c);
        }

    }
}

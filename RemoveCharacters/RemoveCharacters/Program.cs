using System;
using System.Globalization;
using System.Linq;

namespace RemoveCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1= "cats AND*Dogs-are Awesome";
            Console.WriteLine(str1);
            string[] arr = str1.Replace("*", " ").Replace("-", " ").ToLower().Split(" ");
            foreach (var item in arr)
            Console.Write(item);
            Console.WriteLine();
            string firstWord = arr[0];
            //string capitalized = "";
            Console.Write(firstWord);
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write(ti.ToTitleCase(arr[i]));
               // capitalized += arr[i];
            }
            //string final = firstWord + capitalized;
            //Console.WriteLine(final);
        }
            
    }
}

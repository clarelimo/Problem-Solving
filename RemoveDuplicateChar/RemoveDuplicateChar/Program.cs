using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveDuplicateChar
{
    class Program
    {
        static void Main(string[] args)
        {
            DuplicateInteger();
            Console.WriteLine("Enter String with duplicate characters:");
            string duplicate = Console.ReadLine();
            string nonDuplicate = "";
            int total = 0;

            for (int i = 0; i < duplicate.Length; i++)
            {
                for (int j = 1; j < duplicate.Length; j++)
                {
                    if (!nonDuplicate.Contains(duplicate[i]))
                    {
                        nonDuplicate += duplicate[i];
                        total += duplicate[j];
                    }
                }
            }
            Console.WriteLine(nonDuplicate + "," + total);
        }
        static void DuplicateInteger()
        {
            Console.WriteLine("Enter a duplicate integer");
            string dup = Console.ReadLine();
            var hs = new HashSet<char>();
            foreach (var item in dup)
            {
                if (!hs.Contains(item))
                {
                    hs.Add(item);
                }
            }
            Console.WriteLine(string.Join(",", hs));

            
        }
    }
}

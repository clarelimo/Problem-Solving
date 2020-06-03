using System;

namespace RemoveDuplicateChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String with duplicate characters:");
            string duplicate = Console.ReadLine();
            string nonDuplicate = "";

            for (int i = 0; i < duplicate.Length; i++)
            {
                if (!nonDuplicate.Contains(duplicate[i]))
                {
                    nonDuplicate += duplicate[i];
                }
            }
            Console.WriteLine(nonDuplicate);
        }
        static void DuplicateInteger()
        {
            Console.WriteLine("Enter a duplicate integer");
            int dup = Convert.ToInt32(Console.ReadLine());
            int nonDup;

            for (int i = 0; i < dup; i++)
            {
                if (!nonDup.)
                {

                }
            }
        }
    }
}

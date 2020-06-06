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
            Console.WriteLine(nonDuplicate + ","+total);
        }
        static void DuplicateInteger()
        {
            Console.WriteLine("Enter a duplicate integer");
            int dup = Convert.ToInt32(Console.ReadLine());
            int nonDup;

            for (int i = 0; i < dup; i++)
            {
                //if (!nonDup.)
                //{

                //}
            }
        }
    }
}

using System;
using System.Collections;

namespace DuplicateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] duplicateValues = new int[] { 1, 2, 3, 1, 2, 4, 4, 5, 1, 3, 6, 7, 6, 8, 1, 5 };
            
            int[] resultValues =removeDuplicationValues(duplicateValues);
            for (int i = 0; i < resultValues.Length; i++)
            {
            Console.Write(resultValues);
            }
        }
        public static int[] removeDuplicationValues(int[] values)
        {
            ArrayList result = new ArrayList();
            foreach (int s in values)
            {
                if (!result.Contains(s))
                {
                    result.Add(s);
                }
            }
            return (int[])result.ToArray(typeof(int));
        }
    }
}

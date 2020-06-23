using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] duplicateValues = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] other = new int[] { 2, 5, 6 };
            int[] resultValues =removeDuplicationValues(duplicateValues,other);
            Console.WriteLine(string.Join(",", resultValues));
            //for (int i = 0; i < resultValues.Length; i++)
            //{
            //Console.Write(string.Join(",", resultValues[i]));
            //}
        }
        public static int[] removeDuplicationValues(int[] values, int[] nums)
        {
           // ArrayList result = new ArrayList();
            var hs = new List<int>();
            foreach (var item in nums)
            {
                if (item!=0)
                {
                    hs.Add(item);
                }
                
            }
            foreach (var item in values)
            {
                //if (hs.Contains(item))
                //{
                if (item != 0)
                {
                    hs.Add(item);
                }
                //}
            }
            hs.Sort();
            //foreach (int s in values)
            //{
            //    if (!result.Contains(s))
            //    {
            //        result.Add(s);
            //    }
            //}
            return hs.ToArray();/*(int[])result.ToArray(typeof(int))*/;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace IntersectionArray
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            int[] arr1 = new int[]{ 1, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = { 3, 4, 5, 8, 9 };
            Intersection(arr1,arr2);
            Console.WriteLine();
            ConvertToTwoD(arr1,2,3);

        }
        public static void Intersection(int[] arr1, int[] arr2)
        {
            //initialize empty hashset
            HashSet<int> hs = new HashSet<int>();
            //Add every element in the first array to the hs
            for (int i = 0; i < arr1.Length; i++)
                hs.Add(arr1[i]);
            //iterate through the second array and if it contains any element from the first array the print it
            for (int i = 0; i < arr2.Length; i++)
                if (hs.Contains(arr2[i]))
                    Console.Write(arr2[i] + " ");
        }
        public static void ConvertToTwoD(int[] arr1 ,int r1, int c1)
        {
            int index = 0;
            //initialize an empty array to take in the elements
            int[,] two = new int[r1, c1];
            //iterate through the array 
            for (int y = 0; y < r1; y++)
            {
                for (int x = 0; x < c1; x++)
                {
                    two[y, x] = arr1[index];
                    index++;
                    Console.Write(two[y,x]+" ");
                }
            }
            Console.WriteLine();
        }
    }
}

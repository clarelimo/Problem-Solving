using System;

namespace NextGreaterElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int next;
            int[] arr = { 13, 7, 6, 12 };
            for (int i = 0; i < arr.Length; i++)
            {
                next = -1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]<arr[j])
                    {
                        next = arr[j];
                    }
                }
                Console.WriteLine(arr[i]+"--"+next);
            }
        }
    }
}

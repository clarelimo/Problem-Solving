using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7 };
            int[] res = reverse(num, 0, num.Length - 1);
            for (int i = 0; i <= res.Length - 1; i++)
            {
                Console.Write(res[i]);
            }
        }
        public static int[] reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
            return nums;
        }
    }
}

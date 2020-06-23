using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7 };
            int[] res = rotate(num, 3);
            for (int i = 0; i <= res.Length - 1; i++)
            {
                Console.Write(res[i]);
            }

        }
        public static int[] rotate(int[] nums, int k)
        {
            k %= nums.Length;
            reverse(nums, 0, nums.Length - 1);
            reverse(nums, 0, k - 1);
            reverse(nums, k, nums.Length - 1);
            return nums;
        }
        public static void reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}

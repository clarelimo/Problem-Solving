using System;
using System.Collections.Generic;

namespace TappingRainWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,6,8,15};
            Console.WriteLine(Trap(arr));
            LinkedListAdd(arr);
        }
        public static int Trap(int[] height)
        {
            int water = 0;
            int n = height.Length;
            int[] l_max= new int[n];
            l_max[0] = height[0];
            int[] r_max = new int[n];
            r_max[n - 1] = height[n - 1];

            for (int i = 1; i < height.Length; i++)
            {
                l_max[i]= Math.Max(height[i],l_max[i - 1]);
            }
            for (int i = n- 2; i >= 0; i--)
            {
                r_max[i] = Math.Max(height[i], r_max[i+1]);
            }
            for (int i = 0; i < height.Length - 1; i++)
            {
                water += Math.Min(l_max[i], r_max[i]) - height[i];
            }
            return water;

        }
        public static void LinkedListAdd(int[] nums)
        {  
            int n = nums.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int sum = nums[i] + nums[i + 1];
                //Console.WriteLine(sum);
                if (sum < nums[i + 1])
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                break;
            }
        }
    }
}

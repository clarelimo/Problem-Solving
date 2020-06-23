using System;

namespace ReverseIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(-123));
            Console.WriteLine(MultiplicativePersistance(39));
            Console.WriteLine(MultiplicativePersistance(2739));
        }
        public static int Reverse(int num)
        {
            int reversed = 0;
            int rem;
            while (num != 0)
            {
                rem = num % 10;
                reversed = reversed *10 + rem;
                num/=10;
            }
            return reversed;
        }
        public static int MultiplicativePersistance(int num)
        {
            int a;
            int result = 1;
            int count = 0;
            while (num>9)
            {
                while (num != 0)
                {
                    a = num % 10;
                    num = num / 10;
                    result = result * a;
                }
                num = result;
                result = 1;
                count++;
            }      
            return count;
        }
    }
}

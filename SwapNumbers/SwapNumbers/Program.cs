using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int temp = 0;

            Console.WriteLine($"Numbers before swapping:{num1} {num2}" );

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("Numbers after swapping:" +num1 +" "+num2);

        }
    }
}

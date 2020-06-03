using System;

namespace FibionacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine( NthFibionacci() );
            //Iterative method
            Console.Write("Enter the number upto which to display fibionacci series:");
            int number = int.Parse(Console.ReadLine());

            int firstNumber = 0, secondNumber = 1, nextNumber;
            Console.Write(firstNumber +" "+secondNumber +" ");
            
            for (int i = 2; i < number; i++)
            {
                nextNumber = firstNumber + secondNumber;
                Console.Write(nextNumber +" ");
                firstNumber = secondNumber;
                secondNumber = nextNumber;

            }
        }
        public static int NthFibionacci(int number)
        {
            Console.Write("Enter the number upto which to display fibionacci series:");
            int nthNumber = int.Parse(Console.ReadLine());

            nthNumber = nthNumber - 1;

            if (number==0 || number==1)
            {
                return number;
            }
            else
            {
                return NthFibionacci(number - 1) + NthFibionacci(number - 2);
            }
        }
    }
}

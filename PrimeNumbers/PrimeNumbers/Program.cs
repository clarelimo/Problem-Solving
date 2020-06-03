using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPrimeNumber();
            Console.WriteLine("Enter the number to start with:");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number to end with:");
            int endNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"The prime numbers between {startNumber} and {endNumber} are:");

            for (int i = startNumber; i < endNumber; i++)
            {
                int counter = 0;
                for (int j = 2; j < i/2; j++)
                {
                    if (i%j==0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }    
            }
            Console.ReadKey();
        }
        public static void IsPrimeNumber()
        {
            Console.WriteLine("Enter the number to check if its prime:");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;

            for (int i = 2; i < number/2; i++)
            {
                if (number%2==0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("It is a prime number!");
            }
            else
            {
                Console.WriteLine("It is not a prime number");
            }
        }
    }
}

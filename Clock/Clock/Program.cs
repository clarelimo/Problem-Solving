using System;

namespace Clock
{
    class Program
    {
        public static int hour;
        public static int minute;
        public static int angle;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of hours:");
            hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of Minutes:");
            minute = int.Parse(Console.ReadLine());
            ClockAngle();
        }
        public static void  ClockAngle()
        {
            angle = ((11*minute)/2)- (30 * hour);
            Console.WriteLine("The angle of the clock is:" +angle);

        }
    }
}

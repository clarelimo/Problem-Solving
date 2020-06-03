using System;

namespace HoursMinures
{
    class Program
    {     
        static void Main()
        {
            Console.WriteLine(TimeConvert(72));
        }
        public static string TimeConvert(int num)
        {
            int NoOfHours;
            int NoOfMinutes;

            NoOfMinutes = num % 60;
            NoOfHours = num / 60;

            // string result = String.Format("{0}:{1}", NoOfHours, NoOfMinutes);

            return NoOfHours + ":" + NoOfMinutes;
        }
    }
}

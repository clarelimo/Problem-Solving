using System;

namespace HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            HammingDistance();
        }
        public static int HammingDistance()
        {

            int distance = 0;
            
            string[] strArr = { "coder", "codec" };
            string str1 = strArr[0];
            string str2 = strArr[1];
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    distance++;
                }


            }
            Console.WriteLine(distance);
            return distance;
        }
    }
}

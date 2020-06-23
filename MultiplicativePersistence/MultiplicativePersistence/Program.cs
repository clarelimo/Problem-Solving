using System;

namespace MultiplicativePersistence
{
    class Program
    {
        public static int MultiplicativePersistence(int num)
        {

            int result = 0;
            int m = 0;
            string str = num.ToString();

            for (int i = 0; i < str.Length - 1; i++)
            {
                result = Convert.ToInt32(str[i]) * Convert.ToInt32(str[i + 1]);
                str = result.ToString();
                m++;
                if (str.Length <= 1)
                {
                    return m;
                }

            }

            return m;
        }
        public static bool ExOh(string str)
        {
            string x = "";
            string o = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'x')
                {
                    x += str[i];

                }
                else
                {
                    o += str[i];
                }
            }
            if (x.Length == o.Length)
            {
                return true;
            }
            return false;
        }

        static void Main()
        {
            Console.WriteLine(ExOh("xooxxooxxo"));
            Console.WriteLine(MultiplicativePersistence(39));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PrimeChecker
{
   public class Program
    {
        public static List<string> permutations = new List<string>();
        public static void Main(string[] args)
        {

            int num = 910;
            string str = num.ToString();
            int n = str.Length;           
            Permut(str, 0, n - 1);
            foreach (var item in permutations)
            {
                int nums1 = Convert.ToInt32(item);
                if (IsPrime(nums1) == true)
                {
                    Console.WriteLine("Has Prime {0}", nums1);
                }
            }
        }
        //l-start of index.. r.. end of index
        public static void Permut(string str, int l, int r)
        {
            if (l==r)
            {
                // Console.WriteLine(str);
                permutations.Add(str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    Permut(str, l + 1, r);
                    str = swap(str, l, i);         
                }
                            
            }
        }
            //swap characters at position
            //a is the string value, i is the position 1 and j the position 2 and s is the swapped string 
            private static string swap(string a, int i, int j)
            {
                char temp;
                char[] charArray = a.ToCharArray();
                temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;

                string s = new string(charArray);
                return s;
            }

            static bool IsPrime(int num)
            {
                for (int i = 2; i < num / 2; i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
        }
    }


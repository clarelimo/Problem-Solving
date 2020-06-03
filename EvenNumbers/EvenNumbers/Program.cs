using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace EvenNumbers
{
    public class Program
    {
        public int Total { get; set; }
        public static int OpeningBalance { get; private set; }
        public static int kgs { get; private set; }
        public static int price { get; private set; }

        public static void Main(string[] args)
        {
            TotalAmount();
            Balance();
            
        }
        public static void TotalAmount()
        {
            Total = kgs * price;
            Console.WriteLine("The Total Amount bought is:" + Total);
        }
        public static void Balance()
        {
 
            int bal= OpeningBalance - Total;
            Console.WriteLine("The balance is:" + bal);
           
        }
    }
    
}

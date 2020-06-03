using System;

namespace CeaserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input Plain text");
            //string PlainText = Console.ReadLine();
            //Console.WriteLine("Input the shift key");
            //int shift = int.Parse(Console.ReadLine());
            ////Cipher();
            //Encryption(PlainText, shift);
            // keep this function call here
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the key");
            int num = int.Parse(Console.ReadLine());
            CaesarCipher(str, num);
            //Console.ReadLine();
        }
        //public static string Cipher()
        //{

        //}
        public static string Encryption(string PlainText, int shift)
        {
            string Encrypted = "";
            for (int i = 0; i < PlainText.Length; i++)
            {
                char letter = PlainText[i];
                if (char.IsLetter(letter)){
                    if (char.IsUpper(letter))
                    {
                        char r = (char)(letter + shift);
                        if (r > 'Z')
                        {
                            Encrypted += (char)(letter - (26 - shift));
                        }
                        else
                        {
                            Encrypted += r;
                        }
                    }
                    else if(char.IsLower(letter))
                    {
                        char r = (char)(letter + shift);
                        if (r > 'z')
                        {
                            Encrypted += (char)(letter - (26 - shift));
                        }
                        else
                        {
                            Encrypted += r;
                        }
                    }
                }
                else
                {
                    Encrypted += letter;
                }
            }
            Console.WriteLine(Encrypted);
            return Encrypted;
        }
        public static string CaesarCipher(string str, int num)
        {

            // code goes here  
            string Encrypted = "";
            for (int i = 0; i < str.Length; i++)
            {
                char letter = str[i];
                if (char.IsLetter(letter))
                {
                    if (char.IsUpper(letter))
                    {
                        char r = (char)(letter + num);
                        if (r > 'Z')
                        {
                            Encrypted += (char)(letter - (26 - num));
                        }
                        else
                        {
                            Encrypted += r;
                        }
                    }
                    else if (char.IsLower(letter))
                    {
                        char r = (char)(letter + num);
                        if (r > 'z')
                        {
                            Encrypted += (char)(letter - (26 - num));
                        }
                        else
                        {
                            Encrypted += r;
                        }
                    }
                }
                else
                {
                    Encrypted += letter;
                }
            }
            Console.WriteLine(Encrypted);
            return Encrypted;

        }

        //static void Main()
        //{
        //    // keep this function call here
        //    Console.WriteLine("Enter the string");
        //    string str = Console.ReadLine();
        //    Console.WriteLine("Enter the key");
        //    int num = int.Parse(Console.ReadLine);
        //    CaesarCipher(str, num);
        //    //Console.ReadLine();
        //}
    }
}

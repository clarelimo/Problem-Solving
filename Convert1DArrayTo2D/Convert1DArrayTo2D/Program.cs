using System;

namespace Convert1DArrayTo2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int NumOfRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns:");
            int NumOfColumns = int.Parse(Console.ReadLine());
            //Creating 1D array
            Console.WriteLine("Enter the One Dimensional Elements");
            int[] OneDiArray = new int[NumOfRows * NumOfColumns];

            for (int i = 0; i < OneDiArray.Length; i++)
            {
                OneDiArray[i] = int.Parse(Console.ReadLine());
            }
            //creating 2D array
            int index = 0;
            int[,] TwoDiArray = new int[NumOfRows, NumOfColumns];
            for (int x = 0; x < NumOfRows; x++)
            {
                for (int y = 0; y < NumOfColumns; y++)
                {
                    TwoDiArray[x, y] = OneDiArray[index];
                    index++;
                }
            }
            //Printing the 2D array
            Console.WriteLine("The 2D Elements:");
            foreach (int item in TwoDiArray)
            {
                Console.Write(item +" ");
            }
        }
    }
}

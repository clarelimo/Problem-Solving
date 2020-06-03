using System;

namespace Convert2DimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert 2D array to 1D column wise
            int[,] TwoDiArray = new int[2, 3];
            Console.WriteLine("Enter the 2D elements");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TwoDiArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int index = 0;
            //Getting the number of rows
            int NumOfRows = TwoDiArray.GetLength(0);
            //Getting the number of columns
            int NumOfColumns = TwoDiArray.GetLength(1);
            //Creating 1D array by multiplying the number of row by the number of colums
            int[] OneDiArray = new int[NumOfRows * NumOfColumns];
            //Assigning elements from 2D to 1D
            for (int y = 0; y < NumOfColumns; y++)
            {
                for (int x = 0; x < NumOfRows; x++)
                {
                    OneDiArray[index] = TwoDiArray[x, y];
                    index++;
                }
            }
            //Printing the One dimensional array elements
            Console.WriteLine("1D Array Elements:");
            foreach (int item in OneDiArray)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
        //To convert it row wise on assigning the elements from 2D to 1D the outer loop should be on number of rows then inner
        //the number of columns return [y,x]
    }
}

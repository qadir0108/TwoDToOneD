using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDToOneD
{
    internal class Program
    {
        // Source : https://dotnettutorials.net/lesson/how-to-convert-a-two-dimensional-array-to-one-dimensional-array-in-chsrap/
        static void Main(string[] args)
        {
            //Creating a 2d Array with 2 rows and three columns
            int[,] int2DArray = new int[3, 3];
            Console.Write("Enter 2D Array Elements : ");
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    int2DArray[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Getting the no of rows of 2d array 
            int NoOfRows = int2DArray.GetLength(0);
            //Getting the no of columns of the 2d array
            int NoOfColumns = int2DArray.GetLength(1);

            //Creating 1d Array by multiplying NoOfRows and NoOfColumns
            int[] OneDimensionalArray = new int[NoOfRows * NoOfColumns];
            int index = 0;

            //Assigning the elements to 1d Array from 2d array
            int i = 0;
            while (i < NoOfRows)
            {
                int j = 0;
                if (i % 2 == 0)
                {
                    while (j < NoOfColumns)
                    {
                        OneDimensionalArray[index++] = int2DArray[i, j];
                        j++;
                    }
                }
                else
                {
                    // reverse loop from n - 1 to 0
                    j = NoOfColumns - 1;
                    while (j >= 0)
                    {
                        OneDimensionalArray[index++] = int2DArray[i, j];
                        j--;
                    }
                }
                i++;
            }

            //Printing the 1d array elements
            Console.WriteLine("1D Array Elements : ");
            foreach (int item in OneDimensionalArray)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}

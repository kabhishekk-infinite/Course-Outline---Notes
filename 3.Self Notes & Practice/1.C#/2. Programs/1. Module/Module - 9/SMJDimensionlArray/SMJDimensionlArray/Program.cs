using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMJDimensionlArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single-Dimensional Array
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Single-Dimensional Array:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Multi-Dimensional Array
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("\nMulti-Dimensional Array:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Jagged Array
            int[][] jaggedArray = new int[][]
            {
            new int[] { 1, 2 },
            new int[] { 3, 4, 5 },
            new int[] { 6, 7, 8, 9 }
            };
            Console.WriteLine("\nJagged Array:");
            foreach (int[] arr in jaggedArray)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

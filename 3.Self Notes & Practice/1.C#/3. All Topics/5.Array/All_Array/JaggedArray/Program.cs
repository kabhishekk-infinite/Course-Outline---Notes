using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //Jagged Array :-
    //In C#, a jagged array (also known as an array of arrays) is an array whose elements are arrays. 
    // The elements of a jagged array can be of different sizes and dimensions, providing more flexibility than multidimensional arrays.


namespace JaggedArray
{

    class Program
    {
        static void Main(string[] args)
        {
            //Array with Predefined Values
            Console.WriteLine(" ~ ~ ~ Array with Predefined Values ~ ~ ~ ");
            Console.WriteLine("");

            // Declare and initialize a 3D array with predefined values 
            int[][] jaggedArray = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9 }
            };


            // Access and print the elements of the array
            for(int i = 0; i< jaggedArray.Length; i++)
            {
                for(int j = 0; j< jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }


            /*----------------------------------------------------------------------------------------------------------------------------*/


            //Array with User Input Values
            Console.WriteLine(" ~ ~ ~ Array with User Input Values ~ ~ ~ ");
            Console.WriteLine("");

            // Declare a 3D array of specific size
            int[][] JaggedArray = new int[3][];
            JaggedArray[0] = new int[3];
            JaggedArray[1] = new int[2];
            JaggedArray[2] = new int[4];

            // Prompt the user to input values for the array
            for (int i = 0; i < JaggedArray.Length; i++)
            {
                for (int j = 0; j < JaggedArray[i].Length; j++)
                {
                    Console.Write($"Enter value for element at row {i}, column {j}: ");
                    JaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("");

            // Access and print the elements of the array
            Console.WriteLine("The elements in the jagged array are:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
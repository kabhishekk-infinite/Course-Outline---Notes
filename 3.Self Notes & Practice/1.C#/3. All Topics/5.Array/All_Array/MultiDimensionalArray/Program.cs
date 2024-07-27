using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //Multi-Dimensional Array :-
    //In C#, Multi-dimensional arrays are arrays that have more than one dimension, such as two-dimensional or three-dimensional arrays. 
    //These arrays are used to store data in a matrix or grid-like structure.



namespace MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array with Predefined Values
            Console.WriteLine(" ~ ~ ~ Array with Predefined Values ~ ~ ~ ");
            Console.WriteLine("");

            // Declare and initialize a 3D array with predefined values 
            int[,,] array_3D =
            {
                { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                { { 10, 11, 12 }, { 13, 14, 15 }, { 16, 17, 18 } },
                { { 19, 20, 21 }, { 22, 23, 24 }, { 25, 26, 27} }
            };

            // Access and print the elements of the array
            for(int i = 0; i<array_3D.GetLength(0); i++)
            {
                for (int j = 0; j < array_3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array_3D.GetLength(2); k++)
                    {
                        Console.Write(array_3D[i, j, k] +  "\t");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.ReadKey();

            /*-----------------------------------------------------------------------------------------------------------*/

            //Array with User Input Values
            Console.WriteLine(" ~ ~ ~ Array with User Input Values ~ ~ ~ ");
            Console.WriteLine("");

            // Declare a 3D array of specific size
            int[,,] array3D = new int[2, 2, 2];

            // Prompt the user to input values for the array
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write($"Enter value of element at Index Position {i},{j},{k} :  ");
                        array3D[i, j, k] = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("");

            // Access and print the elements of the array
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write(array3D[i, j, k] + "\t");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}

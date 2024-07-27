using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A Two-Dimensional Array :-  Also known as a matrix or a rectangular array.
//Ii s an array of arrays where data is stored in a grid-like format.
//Each element is accessed by specifying two indices: one for the row and one for the column.  


namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array with Predefined Values
            Console.WriteLine(" ~ ~ ~ 2D Array with Predefined Values ~ ~ ~ ");
            Console.WriteLine("");

            // Declare and initialize a 2D array with predefined values
            int[,] matrix1 = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Access and print the elements of the array
            for (int i = 0; i <matrix1.GetLength(0); i++)
            {
                for (int j = 0; j <matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");
            Console.ReadKey();

            /* ---------------------------------------------------------------------------------------------------------------------------------------------*/

            //Array with User Input Values
            Console.WriteLine(" ~ ~ ~ 2D Array with User Input Values ~ ~ ~ ");
            Console.WriteLine("");

            // Declare a 2D array of specific size
            int[,] matrix2 = new int[3, 3];

            // Prompt the user to input values for the array
            Console.Write($"Enter value for element in Matrix :---");

            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write($"\nEnter Value At Index Position {i} {j} : ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("");

            // Access and print the elements of the array
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }



             Console.WriteLine("");
             Console.ReadKey();
        }
    }
}

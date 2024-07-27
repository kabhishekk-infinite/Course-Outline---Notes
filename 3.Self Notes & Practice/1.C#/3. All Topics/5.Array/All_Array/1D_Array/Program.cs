using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //A One-Dimensional Array :-
    //It is a collection of elements of the same type stored in a contiguous memory location.
    //Arrays in C# are zero-indexed, meaning the first element is at index 0.


namespace _1D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array with Predefined Values
            Console.WriteLine(" ~ ~ ~ 1D Array with Predefined Values ~ ~ ~ ");
            Console.WriteLine("");

            // Declare and initialize an array with predefined values.
            int[] arr_num = { 1, 2, 3, 4, 5, 6, 7, 8 };                                     //Integer

            string[] arr_str = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };       //Word

            char[] arr_char = { 'A', 'B', 'C', 'D', 'E' };                                  //Char

            // Access and print the elements of the array
            for (int i = 0; i < arr_num.Length; i++)        //Print Numbers
            {
                Console.WriteLine($"Value At Index Position '{i}'   is  :  {arr_num[i]}");
            }

            Console.WriteLine("");
            Console.ReadKey();

            for (int i = 0; i < arr_str.Length; i++)        //Print Words
            {
                Console.WriteLine($"Value At Index Position '{i}'   is  :  {arr_str[i]}");
            }

            Console.WriteLine("");
            Console.ReadKey();

            for (int i = 0; i < arr_char.Length; i++)        //Print Char
            {
                Console.WriteLine($"Value At Index Position '{i}'   is  :  {arr_char[i]}");
            }

            Console.WriteLine("");
            Console.ReadKey();

            /*-----------------------------------------------------------------------------------------------------------------*/


            //Array with User Input Values
            Console.WriteLine(" ~ ~ ~ 1D Array with User Input Values ~ ~ ~ ");
            Console.WriteLine("");

            // Declare an array of a specific size
            int[] arr_nums = new int[5];

            // Prompt the user to input values for the array
            for (int j = 0; j < arr_nums.Length; j++)
            {
                Console.Write($"Enter the Value At Index Position '{j}'   is  : ");
                arr_nums[j] = int.Parse(Console.ReadLine());           
            }
            
            Console.WriteLine("");

            // Access and print the elements of the array
            for (int k = 0; k < arr_nums.Length; k++)
            {
                Console.WriteLine($"Value At Index Position '{k}'   is  :  {arr_nums[k]}");
            }
            
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}

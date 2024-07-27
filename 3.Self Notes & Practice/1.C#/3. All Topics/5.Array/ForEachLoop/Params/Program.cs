using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Params  :-
//The params keyword in C# allows a method to accept a variable number of arguments.
//This is useful when you don't know beforehand how many arguments will be passed to the method.


namespace Params
{
    class Program
    {
        static void Main()
        {
            PrintDetails("Numbers", 1, 2, 3, 4, 5);
            PrintDetails("More Numbers", 10, 20);

            Console.ReadKey();        
        }

        static void PrintDetails(string title, params int[] numbers)
        {
            Console.WriteLine(title);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

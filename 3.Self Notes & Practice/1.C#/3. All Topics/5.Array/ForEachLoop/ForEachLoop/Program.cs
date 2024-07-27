using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Foreach  :-
//The foreach loop in C# is used to iterate over collections like arrays. It simplifies the iteration process as it does not require an index variable.


namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}

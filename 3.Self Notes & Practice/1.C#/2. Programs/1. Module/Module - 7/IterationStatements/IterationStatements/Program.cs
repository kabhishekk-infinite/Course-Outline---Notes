using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;

            // Using for loop
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum using for loop: " + sum);

            // Using while loop
            sum = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                sum += numbers[index];
                index++;
            }
            Console.WriteLine("Sum using while loop: " + sum);

            // Using do-while loop
            sum = 0;
            index = 0;
            do
            {
                sum += numbers[index];
                index++;
            } while (index < numbers.Length);
            Console.WriteLine("Sum using do-while loop: " + sum);

            // Using foreach loop
            sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Sum using foreach loop: " + sum);

        }
    }
}

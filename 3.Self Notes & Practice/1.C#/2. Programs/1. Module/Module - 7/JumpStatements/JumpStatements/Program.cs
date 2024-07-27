using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStatements
{
    class Program
    {
        static void Main(string[] args)
        {


            //break 
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break; // Exit the loop when i reaches 5
                }
                Console.WriteLine(i);
            }

            //continue
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // Skip even numbers
                }
                Console.WriteLine(i);
            }

            //return
            int Add(int a, int b)
            {
                return a + b; // Return the sum of a and b
            }

            //goto
            int i = 0;
        startLoop:

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 5)
                {
                    goto endLoop;
                }
            }
        endLoop:
            Console.WriteLine("End of loop.");

            //throw
            public void ValidateAge(int age)
            {
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                // Further logic here if age is valid
            }

        }
    }
}

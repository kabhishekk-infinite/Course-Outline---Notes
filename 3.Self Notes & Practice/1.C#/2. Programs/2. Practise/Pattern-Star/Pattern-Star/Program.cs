using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows in patter :  ");
            if (int.TryParse(Console.ReadLine(), out int NumberOfROWS))
            {
                Printpattern(NumberOfROWS);
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input..!! ");
            }
            Console.ReadKey();
        }

        static void Printpattern(int NumberOfROWS)
        {
            Console.WriteLine();
            for (int i = 1; i <= NumberOfROWS; i++)
            {
                for (int j = 1; j<=NumberOfROWS; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("");
            }
        }
     
    }
}

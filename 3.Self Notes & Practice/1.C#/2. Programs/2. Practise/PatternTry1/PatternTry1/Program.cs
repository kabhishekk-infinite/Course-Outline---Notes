using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTry1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the nuber of ROW : ");
            

            if (int.TryParse(Console.ReadLine(), out int numberofROWS))
            {
                PrintNoPattern(numberofROWS);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input...!!!");
            }

            Console.ReadKey();
        }

        static void PrintNoPattern(int numberofROWS)
        {
            Console.WriteLine();
            for (int i = 1; i <= numberofROWS; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
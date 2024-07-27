using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            bool isStudent = true;

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else
            {
                if (isStudent)
                {
                    Console.WriteLine("You are an adult and a student.");
                }
                else
                {
                    Console.WriteLine("You are an adult.");
                }

                switch (age)
                {
                    case 18:
                        Console.WriteLine("Just became an adult.");
                        break;
                    case 21:
                        Console.WriteLine("You can legally drink in some countries.");
                        break;
                    default:
                        Console.WriteLine("Enjoy your adulthood.");
                        break;
                }
            }

        }
    }
}

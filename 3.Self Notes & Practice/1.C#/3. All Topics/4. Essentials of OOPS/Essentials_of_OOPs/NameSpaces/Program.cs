using System;                                
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// NameSpaces  :- 
// Define : A namespace in C# is a way to organize code and create a level of separation and encapsulation (inside a capsule).
// Prevents : Naming Conflicts, by grouping logically related classes, interfaces, enums, and other types. 
// Use : Control the scope of class and method names in larger projects, making code more manageable and avoiding naming collisions.

/* Q. Create different modules like 'MathOperations', 'StringOperations', and 'FileOperations'. 
     You can use namespaces to logically group these operations, making your code more Readable and Maintainable. */

namespace NameSpaces                //The Main Namespace
{

    namespace MathOperations             //Namespace named MathOperations. All the classes defined within this block will belong to the this namespace.
    {
        class Calculator                 //Declares a class named Calculator.
        {
            public int Add(int a, int b)     //A method within the class, that takes two integers as input and returns their sum.
            {
                return a + b;
            }
            public int Subtract(int a, int b)       //A method within the class.
            {
                return a - b;
            }
        }
    }

    namespace StringOperations          //Namespace named StringOperations. All the classes defined within this block will belong to the this namespace.
    {
        class TextManipulator           //Declares a class named TextManipulator.
        {
            public string Concatenate(string a, string b)       //A method within the class.
            {
                return a + b;
            }
            public int GetLength(string s)                      //A method within the class.
            {
                return s.Length;
            }

        }
    }

    namespace LoopOperations           //Namespace named LoopOperations. All the classes defined within this block will belong to the this namespace.
    {
        class ForLoop                 //Declares a class named ForLoop.
        {
            public int SumofEvenNum(int a, int b)               //A method within the class.
            {
                int sum1 = 0;
                for(int i=a; i<=b; i++)
                {
                    if(i % 2 == 0)
                    {
                        sum1 = sum1 + i;
                    }
                }
                return sum1;
            }

            public int SumofOddNum(int a, int b)                //A method within the class.
            {
                int sum2 = 0;
                for (int i = a; i <= b; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum2 = sum2 + i;
                    }
                }
                return sum2;
            }
        }
    }


    class Program                   //Declares a class named 'Program'.
    {
        static void Main(string[] args)         //The Main method is the entry point of the application. 
        {
            // Using MathOperations namespace
            MathOperations.Calculator calculator = new MathOperations.Calculator();     //Creates an instance of the Calculator class from the MathOperations namespace.
            int Sum  = calculator.Add(10, 5);           //Calls the Add method on the calculator object and stores the result in the sum variable.
            int diff = calculator.Subtract(10, 5);
            Console.WriteLine($" SUM        : {Sum}  ");
            Console.WriteLine($" DIFFERENCE : {diff} ");

            Console.ReadKey();

            // Using StringOperations namespace
            StringOperations.TextManipulator textManipulator = new StringOperations.TextManipulator();
            string NewWord = textManipulator.Concatenate("Abhishek", "Kumar");
            int WordLen = textManipulator.GetLength(NewWord);
            Console.WriteLine($"New Word : {NewWord} ");
            Console.WriteLine($"New Word Length : {WordLen} ");

            Console.ReadKey();

            // Using LoopOperations namespace
            LoopOperations.ForLoop forLoop = new LoopOperations.ForLoop();
            int SumofEven = forLoop.SumofEvenNum(0, 10);
            int SumofOdd  = forLoop.SumofOddNum(0, 10);
            Console.WriteLine($"Sum of Even Numbers from 0 to 10 : {SumofEven} ");
            Console.WriteLine($"Sum of Odd Numbers from 0 to 10  : {SumofOdd}  ");

            Console.ReadKey();
        }
    }
}

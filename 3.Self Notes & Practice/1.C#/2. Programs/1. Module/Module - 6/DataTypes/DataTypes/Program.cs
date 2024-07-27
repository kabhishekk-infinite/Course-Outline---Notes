using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Simple types
            int integer = 42;
            float floatingPoint = 3.14f;
            bool boolean = true;
            char character = 'B';

            // Struct type
            Point point = new Point();
            point.X = 10;
            point.Y = 20;

            // Enum type
            Days today = Days.Monday;

            // Nullable type
            int? nullableInt = null;

            // Array type
            int[] numbers = { 1, 2, 3, 4, 5 };

            // String type
            string greeting = "Hello, world!";

            // Object type
            object obj = 42;

            // Dynamic type
            dynamic dyn = 1;
            dyn = "Now I'm a string";

            Console.WriteLine($"Integer: {integer}");
            Console.WriteLine($"Float: {floatingPoint}");
            Console.WriteLine($"Boolean: {boolean}");
            Console.WriteLine($"Character: {character}");
            Console.WriteLine($"Point: ({point.X}, {point.Y})");
            Console.WriteLine($"Today is: {today}");
            Console.WriteLine($"Nullable Int: {nullableInt}");
            Console.WriteLine($"First number in array: {numbers[0]}");
            Console.WriteLine($"Greeting: {greeting}");
            Console.WriteLine($"Object: {obj}");
            Console.WriteLine($"Dynamic: {dyn}");

            //Literals:--

            // Integer literals
            int decimalLiteral = 42;
            int hexLiteral = 0x2A;
            int binaryLiteral = 0b00101010;

            // Floating-point literals
            double doubleLiteral = 3.14;
            float floatLiteral = 3.14f;
            decimal decimalLiteral1 = 3.14m;

            // Character literals
            char charLiteral = 'C';
            char newline = '\n';
            char unicodeChar = '\u0041';

            // String literals
            string stringLiteral = "Hello, world!";
            string verbatimString = @"C:\Users\Abhishek\Documents";

            // Boolean literals
            bool trueLiteral = true;
            bool falseLiteral = false;

            // Null literal
            string nullLiteral = null;

            // Integral suffixes
            uint unsignedLiteral = 42u;
            long longLiteral = 42L;
            ulong unsignedLongLiteral = 42UL;

            Console.WriteLine($"Decimal: {decimalLiteral1}");
            Console.WriteLine($"Hexadecimal: {hexLiteral}");
            Console.WriteLine($"Binary: {binaryLiteral}");
            Console.WriteLine($"Double: {doubleLiteral}");
            Console.WriteLine($"Float: {floatLiteral}");
            Console.WriteLine($"Decimal: {decimalLiteral}");
            Console.WriteLine($"Char: {charLiteral}");
            Console.WriteLine($"Newline: {newline}");
            Console.WriteLine($"Unicode: {unicodeChar}");
            Console.WriteLine($"String: {stringLiteral}");
            Console.WriteLine($"Verbatim String: {verbatimString}");
            Console.WriteLine($"Boolean true: {trueLiteral}");
            Console.WriteLine($"Boolean false: {falseLiteral}");
            Console.WriteLine($"Null: {nullLiteral}");
            Console.WriteLine($"Unsigned: {unsignedLiteral}");
            Console.WriteLine($"Long: {longLiteral}");
            Console.WriteLine($"Unsigned Long: {unsignedLongLiteral}");
        }
         struct Point
        {
            public int X;
            public int Y;
        }

        enum Days
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }
         
    
    }
}
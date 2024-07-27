using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitAndExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion
            int intNum = 100;
            double doubleNum = intNum; // int to double
            Console.WriteLine(doubleNum);

            // Explicit conversion
            double anotherDoubleNum = 123.45;
            int anotherIntNum = (int)anotherDoubleNum; // double to int
            Console.WriteLine(anotherIntNum);

            // Using Convert class
            string str = "456";
            int parsedInt = Convert.ToInt32(str);
            Console.WriteLine(parsedInt);

            // Using Parse method
            string doubleStr = "789.01";
            double parsedDouble = double.Parse(doubleStr);
            Console.WriteLine(parsedDouble);

            // Using TryParse method
            string invalidStr = "not a number";
            if (double.TryParse(invalidStr, out double result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failed to parse");
            }

            // User-defined conversion
            Fraction fraction = new Fraction(3, 4);
            double fractionAsDouble = fraction; // Implicit conversion
            Console.WriteLine(fractionAsDouble);

            Fraction doubleAsFraction = (Fraction)0.75; // Explicit conversion
            Console.WriteLine($"{doubleAsFraction.Numerator}/{doubleAsFraction.Denominator}");
        }
    }

    public class Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        // Define an implicit conversion from Fraction to double
        public static implicit operator double(Fraction fraction)
        {
            return (double)fraction.Numerator / fraction.Denominator;
        }

        // Define an explicit conversion from double to Fraction
        public static explicit operator Fraction(double value)
        {
            int denominator = 10000;
            int numerator = (int)(value * denominator);
            return new Fraction(numerator, denominator);
        }
    }
}

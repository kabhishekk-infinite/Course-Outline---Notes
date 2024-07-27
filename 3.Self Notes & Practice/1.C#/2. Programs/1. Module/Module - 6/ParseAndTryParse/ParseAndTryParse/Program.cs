using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseAndTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string validNumber = "123";
            string invalidNumber = "abc";

            try
            {
                int parsedNumber = int.Parse(validNumber);
                Console.WriteLine($"Parsed successfully: {parsedNumber}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception: Invalid format");
            }

            try
            {
                int parsedNumber = int.Parse(invalidNumber);
                Console.WriteLine($"Parsed successfully: {parsedNumber}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception: Invalid format");
            }

            // Example using Parse
            string validNumber1 = "456";
            string invalidNumber1 = "not a number";

            try
            {
                int parsedNumber1 = int.Parse(validNumber1);
                Console.WriteLine($"Parsed using Parse: {parsedNumber1}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse: Format exception for validNumber");
            }

            try
            {
                int parsedNumber1 = int.Parse(invalidNumber1);
                Console.WriteLine($"Parsed using Parse: {parsedNumber1}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse: Format exception for invalidNumber");
            }

            // Example using TryParse
            if (int.TryParse(validNumber1, out int tryParsedNumber1))
            {
                Console.WriteLine($"Parsed using TryParse: {tryParsedNumber1}");
            }
            else
            {
                Console.WriteLine("TryParse: Failed to parse validNumber");
            }

            if (int.TryParse(invalidNumber1, out tryParsedNumber1))
            {
                Console.WriteLine($"Parsed using TryParse: {tryParsedNumber1}");
            }
            else
            {
                Console.WriteLine("TryParse: Failed to parse invalidNumber");
            }


            int number = 123;

            // Using ToString method
            string str1 = number.ToString();
            Console.WriteLine($"Using ToString: {str1}"); // Output: "123"

            // Using string interpolation
            string str2 = $"{number}";
            Console.WriteLine($"Using String Interpolation: {str2}"); // Output: "123"

            // Using Convert.ToString method
            string str3 = Convert.ToString(number);
            Console.WriteLine($"Using Convert.ToString: {str3}"); // Output: "123"

        }
    }
}

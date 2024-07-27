using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // String class example
            string str = "Hello, World!";
            Console.WriteLine("Original string: " + str);
            Console.WriteLine("Length: " + str.Length);
            Console.WriteLine("Contains 'World': " + str.Contains("World"));
            Console.WriteLine("Index of 'World': " + str.IndexOf("World"));
            Console.WriteLine("Substring: " + str.Substring(7, 5));
            Console.WriteLine("Replace 'World' with 'C#': " + str.Replace("World", "C#"));
            Console.WriteLine("ToUpper: " + str.ToUpper());
            Console.WriteLine("Trim: '" + str.Trim() + "'");

            // StringBuilder class example
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine("\nOriginal StringBuilder: " + sb.ToString());
            sb.Append(", World!");
            Console.WriteLine("After Append: " + sb.ToString());
            sb.Insert(5, ", C#");
            Console.WriteLine("After Insert: " + sb.ToString());
            sb.Remove(5, 4);
            Console.WriteLine("After Remove: " + sb.ToString());
            sb.Replace("World", "C#");
            Console.WriteLine("After Replace: " + sb.ToString());
            Console.WriteLine("Length: " + sb.Length);
            Console.WriteLine("Capacity: " + sb.Capacity);
        }
    }
}

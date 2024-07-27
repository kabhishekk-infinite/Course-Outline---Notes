using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing
            int intValue = 456;
            object boxedInt = intValue; // Boxing
            Console.WriteLine($"Boxed Value: {boxedInt}"); // Output: Boxed Value: 456

            // Unboxing
            object anotherBoxedInt = 789;
            int unboxedInt = (int)anotherBoxedInt; // Unboxing
            Console.WriteLine($"Unboxed Value: {unboxedInt}"); // Output: Unboxed Value: 789

            // Demonstrating boxing and unboxing in a collection
            object[] array = new object[3];
            array[0] = 10;    // Boxing
            array[1] = 20;    // Boxing
            array[2] = 30;    // Boxing

            foreach (object obj in array)
            {
                int value = (int)obj; // Unboxing
                Console.WriteLine($"Array Value: {value}");
            }

            // Performance considerations
            int sum = 0;
            for (int i = 0; i < 1000000; i++)
            {
                object box = i;     // Boxing
                sum += (int)box;    // Unboxing
            }
            Console.WriteLine($"Sum: {sum}"); // This may be slow due to boxing/unboxing overhead

        }
    }
}

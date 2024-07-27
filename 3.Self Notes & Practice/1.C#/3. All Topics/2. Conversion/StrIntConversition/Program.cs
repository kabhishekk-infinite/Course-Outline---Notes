using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrIntConversition
{
    class Program
    {
        static void Main(string[] args)
        {
            //String to Integer. But String should contain Number Only.
            Console.WriteLine("Convertion from String to Integer :----");
            
            Console.Write("ENter a String 1 : ");
            string str1 = Console.ReadLine();
            Console.Write("ENter a String 2 : ");
            string str2 = Console.ReadLine();
            Console.Write("ENter a String 3 : ");
            string str3 = Console.ReadLine();
            Console.Write("ENter a String 4 : ");
            string str4 = Console.ReadLine();

            //COnverting
            int num1 = int.Parse(str1);
            int num2 = Convert.ToInt32(str2);
            int num3;
            if (int.TryParse(str3, out num3))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }
            int num4 = (int)Convert.ChangeType(str4, typeof(int));

            //output
            Console.WriteLine($"Number 1 : {num1}");
            Console.WriteLine($"Number 2 : {num2}");
            Console.WriteLine($"Number 3 : {num3}");
            Console.WriteLine($"Number 4 : {num4}");



            //NOW Integer to String

            Console.WriteLine(" Number is : 123 ");
            int number = 123;

            //Convert Int to Str

            //1 - Using To.string
            string strg1 = number.ToString();

            //2 - Using string interpolation
            string strg2 = $"{number}";

            //3 - Convert.ToString metho
            string strg3 = Convert.ToString(number);

            //output
            Console.WriteLine($"String 1 : {strg1}");
            Console.WriteLine($"String 1 : {strg2}");
            Console.WriteLine($"String 1 : {strg3}");


            Console.ReadKey();

        }
    }
}

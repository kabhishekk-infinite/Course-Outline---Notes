using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //print simple statement
            Console.WriteLine("Hii....!!");
            Console.WriteLine("\n");

            //Now Accept Integer in diff ways.

            //1 -  int.Parse
            //style 1
            Console.Write("Enter Number 1 : ");                 //ask user to enter number.
            string input = Console.ReadLine();                  //read input as string.
            int num1 = int.Parse(input);                        //it convert the string to an int. Note: After typing number and pressing Enter cursor will move to next line.
            Console.Write($"Your Number is : {num1} \n");       //now print the number.

            //style 2
            Console.Write("Again Enter a number :  ");              //everything is same
            int numb = int.Parse(Console.ReadLine());               //merge 2 line into one line.
            Console.WriteLine($"Your another number is : {numb} ");
            Console.WriteLine("");                                  //for extra line for looks

            //2 - convert.ToInt32
            Console.Write("Enter Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your another number is : {num2} ");
            Console.WriteLine("");
            
            //3 - int.TryParse                                  //It returns value in boolean value.
            Console.Write("Enter Number 3 : ");
            string input1 = Console.ReadLine();
            int num3;
            if(int.TryParse(input1, out num3))                  //Or in SINGLE LINE : if(int.TryParse(Console.ReadLIne(), out num3))
            {
                Console.WriteLine($"Your number is : {num3} ");
            }
            else
            {
                Console.WriteLine("Not a NUmber");
            }
            
            Console.WriteLine("");
            
            //4 - Convert.ChangeType                            //It works for converting a string to an Int.
            Console.Write("Enter Number 4 : ");
            string input2 = Console.ReadLine();
            int num4 = (int)Convert.ChangeType(input2, typeof(int));        //int num4 = (int)Convert.ChangeType(Console.ReadLine(), typeof(int));
            Console.WriteLine($"Your another number is : {num4} ");
            Console.WriteLine("");

            //5 - Console.Read                                  //reads a single character and converts it to an integer
            Console.Write("Enter Number 5 : ");
            int num5 = Console.Read() - '0';                    // '0' is subtracted to get the integer value of the character
            Console.ReadLine(); 
            Console.WriteLine($"Your another number is : {num5} ");
            Console.WriteLine("");

            //6 - Consle.ReadKey                                //reads a single keypress and converts it to an integer.
            Console.Write("Enter Number 6 : ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            int num6 = keyInfo.KeyChar - '0';                    // '0' is subtracted to get the integer value of the character
            Console.WriteLine($"\n Your another number is : {num6} ");
            Console.WriteLine("");
            Console.WriteLine("");


            //Now accept string 

            Console.Write("ENter your Name :  ");
            string name = Console.ReadLine();
            Console.WriteLine($"\n Your Name is : {name} ");
            Console.WriteLine("");
            Console.WriteLine("");

            //Now accpt Char

            Console.Write("ENter a CHarracter : ");
            int charcode = Console.Read();
            char char1 = (char)charcode;

            Console.Write("ENter another CHarracter : ");
            char char2 = Console.ReadKey().KeyChar;

            Console.WriteLine($"\nYour Character is : {char1} ");
            Console.WriteLine($"\nYour Character is : {char2} ");

            Console.ReadKey();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopProgs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;
            int d = 5;
            int e = 35;
            int i, j, k;
            double sum = 0.0;
            int[] nums = {1,2,3,4,5,6,7,8};

            Console.Write("\t ~ ~ ~ ~ About Loop ~ ~ ~ ~ ");
            Console.WriteLine("\n Values are : A = 10, B = 20, C = 30, D = 5, E = 35.");
            Console.WriteLine("\n");

            //if :- Used when single condition is there
            Console.WriteLine("If Statement :- Compares A & B");
            if (b>a)
            {
                Console.WriteLine($" Condition 1 : B: {b} is greater than A: {a}.");
            }

            Console.WriteLine("");
            Console.ReadKey();

            //if-else :- When conditon will give either true or false output.
            Console.WriteLine("If-else Statement :- Compares B & C ");
            if (b>c)
            {
                Console.WriteLine($" Condition 1 : B: {b} is greater than C: {c} ");
            }
            else
            {
                Console.WriteLine($" Condition 2 : C: {c} is greater than B: {b} ");
            }

            Console.WriteLine("");
            Console.ReadKey();

            //else-if  :- When multiple conditions are there.Only Executed the block whose conditions gets true.
            Console.WriteLine("Else-if Statement :- Compares A & B & C");
            if (a>b && a>c)
            {
                Console.WriteLine($" Condition 1 : A: {a} is greater than B: {b} & C: {c} ");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine($" Condition 2 : B: {b} is greater than A: {a} & C:{c} ");
            }
            else if(a>b && a<c)
            {
                Console.WriteLine($" Condition 3 : A: {a} is greater than B: {b} and smaller than C: {c}. ");
            }
            else
            {
                Console.WriteLine($" Condition 4 : C: {c} is greater than A: {a} & B: {b} ");
            }

            Console.WriteLine("");
            Console.ReadKey();

            //switch  :- When one block has to be used among many conditions.
            Console.WriteLine("Switch Statement :- Prints Fruit name according to choice...!! ");
            
            Console.Write("Enter any number between (1-4) : ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Here is your Gift at 1 : Mango. ");
                    break;
                case 2:
                    Console.WriteLine("Here is your Gift at 2 : Apple. ");
                    break;
                case 3:
                    Console.WriteLine("Here is your Gift at 3 : Grapes. ");
                    break;
                case 4:  
                    Console.WriteLine("Here is your Gift at 4 : Banana. ");
                    break;
                default:
                    Console.WriteLine("   Sorry, No Gifts...!!   ");
                    break;
            }

            Console.WriteLine("");
            Console.ReadKey();

            //for :- When you knows the number of loops 
            Console.WriteLine("FOR Loop :- numbers from 0 to 5 and their sum ");
            for (i=0; i<=5; i++)
            {
                Console.WriteLine($"The Number is {i}");
                sum = sum + i;
            }
            Console.WriteLine($"The Sum is {sum}");

            Console.WriteLine("");
            Console.ReadKey();

            //while  :- Executes until specified conditions get true.
            Console.WriteLine("While Loop :- numbers from 1 to 5 and their sum");
            j = 1;
            while(j<6)
            {
                Console.WriteLine($"The Number is {j}");
                sum = sum + j;
                j++;
            }
            Console.WriteLine($"The Sum is {sum}");

            Console.WriteLine("");
            Console.ReadKey();

            //do-while  :- Runs atleast one time without any condition getting true.
            Console.WriteLine("Do While Loop :");
            j = 1;
            do
            {
                Console.WriteLine($"The Number is {j}");
            }
            while (j < 1);

            Console.WriteLine("");
            Console.ReadKey();

            //foreach  :- Iterates through each elements of array. use-when need to access each element.
            Console.WriteLine("Foreach Loop :- Displaying Each Value of Array.");
            Console.WriteLine("The array is :-  nums[] = {1,2,3,4,5,6,7,8} ");

            foreach (int num in nums)
            {
                Console.WriteLine($"The Number is {num}");
            }

            Console.WriteLine("");
            Console.ReadKey();

            //break  :- terminates the closest enclosing loop or switch statement.
            Console.WriteLine("Break Statement : break when i==5 from 0 to 9. ");
            for (i=0; i<10; i++)
            {
                if(i == 5)
                {
                    break;      // Exit the loop when i is 5
                }
                Console.WriteLine($"The Number is {i}");
            }

            Console.WriteLine("");
            Console.ReadKey();

            //continue  :- The continue statement skips the current iteration of the closest enclosing loop and proceeds to the next iteration.
            Console.WriteLine("Continue Statement : will skip even numbers from 0 to 9. ");
            for (i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;      // Skip even numbers
                }
                Console.WriteLine($"The Number is {i}");
            }

            Console.WriteLine("");
            Console.ReadKey();

            //return  :- The return statement terminates the execution of a method and optionally returns a value to the caller.
            Console.WriteLine("Return Statement : return value from a method. ");
            int result = Add(a, b);
            Console.WriteLine($"sum is {result}");

            int Add(int A, int B)
            {
                return A + B;
            }

            Console.WriteLine("");
            Console.ReadKey();

            //goto  :- The goto statement transfers control to a labeled statement within the same method.
            Console.WriteLine("Goto Statement : jump to the lable start till k=10, from 5 to 10.");
            k = 5;

            Start:
            Console.WriteLine($"The numbers are : {k} ");
            k++;

            if(k<=10)
            {
                goto Start;         // Jump to the label Start
            }

            Console.WriteLine("");
            Console.ReadKey();

            //throw  :- The throw statement is used to signal the occurrence of an exception.
            Console.WriteLine("Throw Statement : Try~Catch -  Throw an exception. if number is neg ");
           
            //With Positive Number.
            Console.Write("Please enter a Pos number :  ");
            int posnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            try
            {
                TestMethod1(posnum);                                 //is a method that checks that input number is pos or neg. 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception Message : " + ex.Message);     //If neg then Throws Exceptions Message.
            }

            void TestMethod1(int Posnum)
            {
                if (Posnum < 0)
                {
                    throw new ArgumentException(" Number Can't be Negative. ");         // Throw an exception
                }
                Console.WriteLine($"The number is : {Posnum} ");
            }

            Console.WriteLine("");
            Console.ReadKey();

            //With Negative Number. - shows Exceptions.
            Console.Write("Please enter a Neg number :  ");
            int negnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            try
            {
                TestMethod2(negnum);                                 //is a method that checks that input number is pos or neg. 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception Message : " + ex.Message);     //If neg then Throws Exceptions Message.
            }

            void TestMethod2(int Negnum)
            {
                if (Negnum < 0)
                {
                    throw new ArgumentException(" Number Can't be Negative. ");         // Throw an exception
                }
                Console.WriteLine($"The number is : {Negnum} ");
            }

            Console.WriteLine("");
            Console.WriteLine(" ~ ~ ~ ~ ~ DONE ~ ~ ~ ~ ~ ");
            Console.ReadKey();

        }
    }
}

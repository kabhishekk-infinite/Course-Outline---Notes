using System;                          //Namespaces
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAndOutput            //Namespace Declaration
{
    class Program                   //Class Declaration 
    {
        static void Main(string[] args)     //Main Method
        {
            Console.Write("\t ~ ~ ~ ~ HELLO ~ ~ ~ ~");                            //Cr in same line.
            Console.WriteLine("\n");                                                //used for changing line twice
            Console.WriteLine("  Infinite Conmuter Solutions (India) Ltd.  ");          //1st - print then 2nd line change
            Console.Write("\t  Banglore , Karnataka.\n");                            //start in new line with tabular space but Cr in same line. but \n used for changing Cr.
            Console.WriteLine("   \t    PINCODE : 562157");                               //NOrmal Print
            Console.WriteLine("");
            Console.Write("\n");

            Console.Write("Enter Your Full Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Up.Age    : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Your D.O.B     : ");
            string dob = Console.ReadLine();

            Console.Write("Enter Your Sex (M/F) :");
            char sex = Console.ReadKey().KeyChar;

            Console.Write("\nEnter Your Address   : ");
            string address = Console.ReadLine();

            Console.Write("Enter Your Phone No  : ");
            string phoneno = Console.ReadLine();

            Console.Write("Enter Your Blood Grp : ");
            string bloodgrp = Console.ReadLine();

            Console.Write("Enter Your Mail ID   : ");
            string mailId = Console.ReadLine();

            Console.Write("Enter Your Purpose Of Visit :");
            string purpose = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");

            string title; 

            if (sex == 'M')
            {
                 title = " Mr.";
            }
            else if (sex == 'F')
            {
                 title = " Mrs.";
            }
            else
            {
                  title = " ";
            }

            Console.WriteLine($"  Hello {title} {name}, welcome to Infinite Conmuter Solutions (India) Ltd.");
            Console.WriteLine("");
            Console.WriteLine("  Here are your Details :--  ");
            Console.WriteLine("");
            Console.WriteLine($"  Your Age is {age} according to your Date Of Birth : {dob} And your Blood Group is : {bloodgrp}");
            Console.WriteLine($"  Your Contact Number is : {phoneno} and your Mail ID is : {mailId}. ");
            Console.WriteLine($"  Your Purpose of visit is : {purpose} ");
            Console.WriteLine("");
            Console.WriteLine("\t ~ ~ ~ ~ Thank You ~ ~ ~ ~ ");


            Console.ReadKey();                                                      //execute only when accpt any key
        }
    }
}

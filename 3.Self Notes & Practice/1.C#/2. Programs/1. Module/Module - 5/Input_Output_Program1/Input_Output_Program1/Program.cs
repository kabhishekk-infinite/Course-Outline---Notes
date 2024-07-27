using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Output_Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input and Output Program
            Console.WriteLine("  ~~  Welcome New Students  ~~  ");
           
            //School Details
            string schoolname = " ~ St. Xavier's High School ~";
            string address = "Patna , Bihar.";
            int pincode = 800020;
            
            //Entr Student Details
            Console.Write("ENTER YOUR First Name  :  ");
            string fname = Console.ReadLine();

            Console.Write("ENTER YOUR Last Name  :  ");
            string lname = Console.ReadLine();

            Console.Write("\n ENTER YOUR Gender 'M' or 'F' :  ");
            string gender = Console.ReadLine();
            
            Console.Write(" \n ENTER YOUR AGE  :  ");
            int age = int.Parse(Console.ReadLine());
            
            Console.Write("\n ENTER YOUR Father's Name  :  ");
            string faname = Console.ReadLine();
            
            Console.Write(" \n ENTER YOUR Phone Number  :  ");
            string phnum = Console.ReadLine();
            
            Console.Write(" \n ENTER YOUR DOB in (DD/MM/YYYY) format :  ");
            string dob = Console.ReadLine();

            //Display
            Console.WriteLine("\n  ~~  Welcome  ~~  ");
            Console.WriteLine(schoolname);
            Console.WriteLine(address);
            Console.WriteLine("Pincode : " + pincode);
            Console.WriteLine(" Your Father's Name : " + faname);
            Console.WriteLine($" Your Name is : {fname} {lname}");
            Console.WriteLine($" Your Gender is : {gender}");
            Console.WriteLine($" Your age is {age}");
            Console.WriteLine(" Your Phone Number is : +91 " + phnum);
            Console.WriteLine($" Your Date of Birth is : {dob}");
            Console.WriteLine(" Your Grade is : A+ ");

            Console.ReadKey();
        }
    }
}

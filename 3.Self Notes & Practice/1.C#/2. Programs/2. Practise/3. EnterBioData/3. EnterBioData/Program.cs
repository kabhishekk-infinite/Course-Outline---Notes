using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EnterBioData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Admission in college.
            
        }
        Console.Write();
            Console.WriteLine();

            
            Console.Write();
            string name = Console.ReadLine();
        Console.Write();
            int age = int.Parse(Console.ReadLine());

        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
    }

    static void SchoolIntro(string[] args)
    {
        //About School
        Console.Write("        ~~~ Welcome ~~~       ");
        Console.Write("     A.B.C. High School    ");
        Console.Write("    Bangalore, Karnataka    ");
        Console.Write("");
        Console.Write("    ~~~ Admission Form ~~~");
        Console.WriteLine("    ~~ Class 11 ~~  ");

    }

    static void AboutStudent(string[] args)
    {
        //About Student's Details
        Console.Write("Name : ");
        Console.Write("Age : ");
        Console.Write("D.O.B");
        Console.Write("Mobile No :");
        Console.Write("Mail ID");
        Console.Write("Blood Group : ");
        Console.Write("Address : ");
        Console.Write("State :");

    }

    static void AboutParents(string[] args)
    {
        //About Parent's Details
        Console.Write("Father's Name : ");
        Console.Write("Mobile no : ");
        Console.Write("Mother's Name : ");
        Console.Write("Mobile no : ");
        Console.Write("Annual Salary : ");

    }

    static void Class10thResult(string[] args)
    {
        //About Class 10th Result
        Console.Write("School Name : ");
        Console.Write("Educational board :  ");
        Console.Write("Medium Of Study : ");
        Console.Write("Address :  ");
        Console.Write("Year of Passing : ");
        Console.Write("Total Marks : ");
        Console.Write("Grade : ");
        Console.Write("Phy + Chem + Math + Eng + Hin , Marks : ");
        //Convert into % and CGPA both
        Console.Write("Percentage % : ");
        Console.Write("CGPA : ");
    }

    static void Class12thResult(string[] args)
    {
        //About Class 12th Result
        Console.Write("School Name : ");
        Console.Write("Educational board :  ");
        Console.Write("Medium Of Study : ");
        Console.Write("Address :  ");
        Console.Write("Year of Passing : ");
        Console.Write("Total Marks : ");
        Console.Write("Grade : ");
        Console.Write("Phy + Chem + Math + Eng + Hin , Marks : ");
        //Convert into % and CGPA both
        Console.Write("Percentage % : ");
        Console.Write("CGPA : ");
    }

    static void EligableOrNot(string[] args)
    {
        // Eligable Or Not for direct Admission on the basis of Marks.
        Console.Write(" ~~ Eligable Criteria ~~ ");
        Console.Write("10th % >= 80% or 9.0 CGPA ");
        Console.Write("12th % >= 70% or 8.0 CGPA");
        Console.Write(" Marks Compare : ");
        if ()
        {
            Console.Write(" Congrats yor are eligable for Direct Admission ");
        }
        else
        {
            Console.Write(" Sorry, But are not eligable for Direct Admission ");
            Console.Write(" Now you have two choice :  ");

            switch ()
            {
                case 1: Clear Entrance Exam for Admission
                    {

                    }
                case 2: Admission through Donation.
                    {

                    }
            }
        }



    }

    static void Donation(string[] args)
    {
        // If not eligable then admission through donation 
        Console.Write("Donations depends on Eligibility Conditions : ");
        Console.Write(" Marks in Phy + Chem + Math & Eng :-- ");
        Console.Write(" Conditions : ");
        Console.Write(" Marks of PCM in Class 10/12 is : ");
        Console.Write("PCM >= 80 then Rs. 25,000/- ");
        Console.Write(" PCM < 80 && PCM >= 65 then Rs. 50,000/- ");
        Console.Write(" PCM < 65 && PCM >= 50 then Rs. 50,000/- ");
        Console.Write(" PCM < 50 then Fail ");
        Console.Write(" Marks in English :-- ");
        Console.Write(" Conditions : ");
        Console.Write(" Marks of Eng in Class 10/12 is : ");
        Console.Write(" Eng >80 then Rs. 10,000/- ");
        Console.Write(" Eng >=65 then Rs. 20,000/- ");
        Console.Write(" Eng >=50 && Eng >= 50 then Rs. 30,000/- ");
        Console.Write(" Eng  >40 && Eng <50 then 35,000/- Fail");
        Console.Write(" Eng == 40 then Rs. 40,000/- ");
        Console.Write(" Your marks in PCM :  ");
        Console.Write(" Your marks in Eng :  ");
        Console.Write(" So, Your Donation Total Amount :  ");

    }

    static void FinalDisplay(string[] args)
    {
        // Now Final Decision of Student.
        Console.Write("Name of Student : ");
        Console.Write("Name of Father : ");
        Console.Write("Name of Mother : ");
        Console.Write("Age : ");
        Console.Write("Mobile No : ");
        Console.Write("Email ID : ");
        Console.Write("Address : ");
        Console.Write("Class 10th Grade :  ");
        Console.Write("Year of Passing :  ");
        Console.Write("Class 12th Grade :  ");
        Console.Write("Mode of Admission :  ");
        if (Direct)
        {
            Console.Write(" Congratulation for Direct Admission : ");
            Console.Write(" Best Of Luck for Your Future ");
            Console.Write(" You can contact Admission Center for Furthur Process ");
            Console.Write(" Thank You !");
        }
        if else (Cracked Exam)
        {
            Console.Write(" Congratulation for Cracking Exam ");
            Console.Write(" Now, you ae elligble for Admission in college without any donation amount. ");
            Console.Write(" Best Of Luck for Your Future ");
            Console.Write(" You can contact Admission Center for Furthur Process ");
            Console.Write(" Thank You !");

        }
        else
        {
            Console.Write(" You are eligible for admission only through donation ");
            Console.Write(" Your total donation amount is :   with GST");
            Console.Write(" Best Of Luck for Your Future ");
            Console.Write(" You can contact Admission Center for Furthur Process ");
            Console.Write(" Thank You !");
        }
    }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Encapsulation  :-
//Encapsulation is one of the fundamental principles of object-oriented programming (OOP).
//It refers to the bundling of data (attributes) and methods (functions) that operate on the data into a single unit or class, and restricting access to some of the object's components.

/* Q. To demonstrates encapsulation using a 'Student' class. Field : name, age, grade*/
namespace Encapsulation
{
    //Define CLass
    public class Student
    {
        //Private Fields 
        private string name;
        private int age;
        private double grade;

        //Constructor to initialize the Field
        public Student(string name, int age, double grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        //Now Get and Set
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        //Method to display
        public void DisplayDetails()
        {
            Console.WriteLine($"Student Name : {name} \nAge : {age} \nGrade : {grade}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" Detail :- ");
            //Create an instance of class 'Student'
            Student student1 = new Student("Abhishek Kumar", 25, 8.5);
            student1.DisplayDetails();
            Console.WriteLine("");

            Student student2 = new Student("Om Verma", 24, 8.0);
            student2.DisplayDetails();
            Console.WriteLine("");

            Student student3 = new Student("Ankit Kumar", 23, 7.5);
            student3.DisplayDetails();
            Console.WriteLine("");

            //Modifications
            Console.WriteLine("Modifications : -----\n\n");

            student1.Name = "Abhishek";
            student1.DisplayDetails();
            Console.WriteLine("");

            student2.Name = "OM Verma";
            student2.DisplayDetails();
            Console.WriteLine("");

            student1.Age = 27;
            student3.Age = 24;
            student1.DisplayDetails();
            Console.WriteLine("");

            student3.DisplayDetails();
            Console.WriteLine("");

            student3.Grade = 7.0;
            student1.Grade = 8.0;
            student2.Grade = 8.5;
            student1.DisplayDetails();
            Console.WriteLine("");

            student2.DisplayDetails();
            Console.WriteLine("");

            student3.DisplayDetails();
            Console.WriteLine("");


            Console.ReadKey();
        }
    }
}

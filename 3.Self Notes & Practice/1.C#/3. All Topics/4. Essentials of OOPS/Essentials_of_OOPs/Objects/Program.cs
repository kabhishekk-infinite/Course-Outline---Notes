using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        //Objects  :-
        //Instantiating an object means creating an instance of a class. 
        //Working with objects involves calling their methods and accessing their properties. 
        
    /* Q. Define a class representing 'Person'. Properties such as : 'Name' & 'Age' and a method to display the person's details. */


namespace Objects
{
    //Class name Person.
    public class Person
    {
        //Properties.
        private string name;
        private int age;

        //constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //Now get and set
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

        //Method to display Person
        public void DisplayDetails()
        {
            Console.WriteLine($"  Name : {name}  \n  Age : {age}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(" Abhishek Kumar ", 25);        //Instantating Person.
            person1.DisplayDetails();                                   //working with Object.

            Person person2 = new Person("Ankit Kumar ", 24);            //Instantating Person.
            person2.DisplayDetails();                                   //working with Object.

            /
            //Modify Person2
            person2.Name = "Om Verma";
            person2.Age = 23;
            person2.DisplayDetails();       //Display After Change.  

            Console.ReadKey();
        }
    }
}

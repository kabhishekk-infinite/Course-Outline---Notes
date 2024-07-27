using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Inheritance : 
//Define : Inheritance allows one class (derived or child class) to inherit the members (fields, properties, methods) of another class (base or parent class).
//This enables code reuse and promotes the concept of hierarchical classification.
//Inheritance is a fundamental concept in object-oriented programming (OOP) and C# supports it fully.

//Key Point:
//1. Base Class: The class whose members are inherited.
//2. Derived Class: The class that inherits members from the base class.
//3. Access Modifiers: Control the accessibility of base class members to the derived class. Common access modifiers include public, protected, and private.
//4. Overriding: Derived classes can provide specific implementations for methods defined in the base class using the override keyword.
//5. 'base' Keyword: Used to access members of the base class from within the derived class.

//Access Modifiers in Inheritance:
// ~ Public: Public members of the base class are accessible to the derived class.
// ~ Protected: Protected members are accessible within the base class and any class derived from it, but not from outside.
// ~ Private: Private members are not accessible in derived classes.

/* Q. Example where we have a base class called Animal and a derived class called Dog.*/
//Steps :
//Create the Base Class (Animal)
//Create the Derived Class (Dog)
//Demonstrate Inheritance


namespace Inheritance
{    
    //Base Class
    public class Animal                             //Base class.
    {
        //Property.
        public string Name { get; set; }            
        public int Age { get; set; }                

        //Methods
        public void Eat()
        {
            Console.WriteLine($"{Name} is Eating. ");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is Sleeping. ");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} is making a Sound. ");
        }
    }

    // Derived class
    public class Dog : Animal                                   //This is the derived class inheriting from Animal.
    {
        public String Breed { get; set; }                       //additional property .
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is barking.");           //Overrides the MakeSound method to provide a specific implementation for dogs.
        }
        public void Fetch()                                      
        {
            Console.WriteLine($"{Name} is fetching the ball.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //The Main method creates instances of Animal and Dog .
            //Demonstrates the use of inherited and overridden methods.

            // Creating an instance of the base class
            Animal MyAnimal = new Animal();                 //Instances of Animal.
            MyAnimal.Name = "Rocky";
            MyAnimal.Age = 10;
            MyAnimal.Eat();
            MyAnimal.Sleep();
            MyAnimal.MakeSound();

            Console.WriteLine();

            // Creating an instance of the derived class
            Dog MyDog = new Dog();                         //Instances of Dog.
            MyDog.Name = "Pluto";
            MyDog.Age = 5;
            MyDog.Breed = "Husky";
            MyDog.Eat();
            MyDog.Sleep();
            MyDog.MakeSound();
            MyDog.Fetch();

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
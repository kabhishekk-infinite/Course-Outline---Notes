using System;                                       //Imports the System namespace.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Classes  :--
//Defination : A class in C# is a blueprint or template for creating objects.  A class defines the properties (attributes) and behaviors (methods).

/* Q. A class representing a car. This class will have properties such as brand, model, and year, and methods to display the car details.*/

namespace Classes                   //Namespace - Main.
{
    namespace CarNamespace          //Namespace.
    {
        public class Car            //Class name Car (public).
        {
            //Properties (attributes)
            private string brand;               //Private field name.
            private string model;
            private int year;

            // Constructor
            public Car(string brand, string model, int year)        // Declares a public constructor for the 'Car' class. 
            {
                this.brand = brand;                 //Sets the private 'brand' field to the value passed to the constructor.
                this.model = model;
                this.year = year;
            }

            // Properties to get and set the brand
            public string Brand             // Declares a public property named 'Brand' with a getter and setter, providing controlled access to the private brand field.
            {
                get { return brand; }
                set { brand = value; }
            }

            // Properties to get and set the model
            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            // Properties to get and set the year
            public int Year
            {
                get { return year; }
                set { year = value; }
            }

            // Method (behaviors) to display car details
            public void DisplayDetails()            // Declares a public method named 'DisplayDetails'.
            {
                Console.WriteLine($"Car : {brand} {model} , year : {year}");
            }
        }

        class Program
        {
            static void Main(String[] args)
            {
                // Creating instances of the Car class
                Car car1 = new Car("Honda", "Civic", 2019);         //Creates an instance of the 'Car' class with the specified 'brand', 'model', and 'year'.
                car1.DisplayDetails();                              //Calls the DisplayDetails method on the car1 object, which prints the car details to the console.

                Car car2 = new Car("Toyota", "Corolla", 2020);
                car2.DisplayDetails();

                Console.ReadKey();
            }
        }
    }
}

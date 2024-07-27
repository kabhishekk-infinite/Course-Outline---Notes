using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Type Hierarchy  :-
//In OOP, type hierarchy refers to the way different types (classes, interfaces, etc.) are organized in a parent-child relationship.
//This hierarchy allows for inheritance, polymorphism, and code reuse.

//Key Concepts :
//1. Base Class: The top class in the hierarchy.
//2. Derived Class: A class that inherits from another class.
//3. Abstract Class: A class that cannot be instantiated and is meant to be a base class for other classes.
//4. Interface: A contract that defines a set of methods and properties that implementing classes must provide.

/* Q. Prog in which base class 'Shape', an abstract class 'TwoDimensionalShape', and derived classes 'Circle' and 'Rectangle'. */

//Steps :
// Create the Base Class (Shape)
// Create the Abstract Class (TwoDimensionalShape)
// Create the Derived Classes (Circle and Rectangle)
// Implement an Interface (IDrawable)


namespace TypeHierarchy
{
    // Interface definition
    public interface IDrawable                    //Defines the Draw method that must be implemented by any class that implements this interface.
    {
        void Draw();
    }

    //Base CLass
    public class Shape : IDrawable              //Shape class - The base class that implements the IDrawable interface and provides a basic implementation of the Draw method.
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public virtual void Draw()
        {
            Console.WriteLine($" Drawing a {Name} ");
        }
    }

    //Abstract Class.
    public abstract class TwoDimensionalShape : Shape                   //TwoDimensionalShape Class: An abstract class that inherits from Shape and adds an abstract method GetArea.
    {                                                                   //This class cannot be instantiated and serves as a base for specific 2D shapes.
   
        public TwoDimensionalShape(string name) : base(name) { }

        public abstract double GetArea();
    }

    //Derived Class
    public class Circle : TwoDimensionalShape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Name} with radius {Radius}");
        }
    }

    //Derived Class
    public class Rectangle : TwoDimensionalShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double lenght, double width) : base("Rectangle")
        {
            Length = lenght;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Name} with length {Length} and width {Width}");
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                // Creating instances of the derived classes
                Circle MyCircle = new Circle(5);
                Rectangle MyRectangle = new Rectangle(4, 6);

                //Drawing the shapes : 
                MyCircle.Draw();
                MyRectangle.Draw();

                // Displaying the area of the shapes
                Console.WriteLine($"Area of the circle: {MyCircle.GetArea()}");
                Console.WriteLine($"Area of the rectangle: {MyRectangle.GetArea()}");

                Console.ReadLine();
            }
        }
}





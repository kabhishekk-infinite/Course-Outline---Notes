using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hiding Base Class Member
//Define : Can hide a member of the base class in the derived class by using the new keyword.
//an hide a member of the base class in the derived class by using the new keyword.
//This is different from overriding, where the base class method is overridden to provide a new implementation.

/* Base Class members in 2020-2023*/

//Key Concepts:
//1. Base Class Member: The member(method, property, etc.) in the base class that is to be hidden.
//2. Hiding: Using the new keyword to hide the base class member in the derived class.
//3. Method Overriding: Using the override keyword to provide a new implementation for a base class method in the derived class.


/* Q. Let's create a base class 'BaseClass' with a method 'ShowMessage'.
 * Then, we'll create a derived class 'DerivedClass' that hides the 'ShowMessage' method. */

//Steps :
//1. Create the Base Class (BaseClass)
//2. Create the Derived Class (DerivedClass)
//3. Demonstrate Hiding of Base Class Member

namespace HidingBaseClassMember
{
    //Base CLass
    public class BaseClass                                      //The base class with a method ShowMessage that prints a message.
    {
        public void ShowMessage()
        {
            Console.WriteLine("Message from Base Class.");
        }
    }

    //Derived Class
    public class DerivedClass : BaseClass
    {
        public new void ShowMessage()
        {
            Console.WriteLine("Message from Derived Class.");
        }
    }
        

    class Program
    {
        static void Main(string[] args)         /* The Main method demonstrates the difference between calling the hidden method directly from the base class instance and calling it from the derived class instance.   */
        {
            //Base Class Instance
            BaseClass baseClassObj = new BaseClass();
            baseClassObj.ShowMessage();

            //Derived Class Instance
            DerivedClass derivedClassObj = new DerivedClass();
            derivedClassObj.ShowMessage();

            //Derived Class Instance but Referenced as Base Class
            BaseClass polymorphicObj = new DerivedClass();                  // The derived class that hides the ShowMessage method from the base class using the new keyword.
            polymorphicObj.ShowMessage();                                   //This method prints a different message.


            Console.ReadLine();
        }
    }

}

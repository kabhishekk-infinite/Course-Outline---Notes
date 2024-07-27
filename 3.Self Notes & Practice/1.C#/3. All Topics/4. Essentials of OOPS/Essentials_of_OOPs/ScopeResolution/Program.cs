using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Scope Resolution  :-
//The rules and mechanisms by which a programming lang. determines the context in which a name (variable, method, or type) is defined and used.
//The scope resolution is managed using namespaces and class hierarchies.
//The "." operator is used to access members of a namespace or class.


namespace ScopeResolution                           //Name of Main Namespace
{

    namespace OuterNamespace                        //Name of Namespace
    {
        class OuterClass                            //Name of CLass - Outer
        {
            public void Display()                   //A Method within the CLass
            {
                Console.WriteLine("OuterClass Display Method");
            }

            public class InnerClass                 //Name of CLass - Inner
            {
                public void Display()               //A Method within the CLass
                {
                    Console.WriteLine("InnerClass Display Method");
                }
            }
        }
    }       

    namespace AnotherNamespace                  //Name of Namespace
    {
        class OuterClass
        {
            public void Display()
            {
                Console.WriteLine("AnotherNamespace OuterClass Display Method");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Using OuterNamespace
            OuterNamespace.OuterClass outer = new OuterNamespace.OuterClass();        //Creates the instance of the 'OuterClass' form 'OuterNamespace'. Object is : 'outer'.
            outer.Display();            // Calls the Display method on the outer object, which prints "OuterClass Display Method".

            Console.ReadKey();

            // Using OuterNamespace.InnerClass
            OuterNamespace.OuterClass.InnerClass inner = new OuterNamespace.OuterClass.InnerClass();        // Objects is : 'inner'.
            inner.Display();

            Console.ReadKey();

            // Using AnotherNamespace
            AnotherNamespace.OuterClass anotherOuter = new AnotherNamespace.OuterClass();
            anotherOuter.Display();

            Console.ReadKey();
        }
    }
}

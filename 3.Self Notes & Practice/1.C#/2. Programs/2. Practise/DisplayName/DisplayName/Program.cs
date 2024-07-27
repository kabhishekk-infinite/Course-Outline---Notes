using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace displayname
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Hello ," + name + "!");
            Console.ReadKey();
        }
    }
}

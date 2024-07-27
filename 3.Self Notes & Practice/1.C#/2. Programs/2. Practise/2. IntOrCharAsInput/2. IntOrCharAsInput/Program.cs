using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IntOrCharAsInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Your Number : " + num);
        }
    }
}

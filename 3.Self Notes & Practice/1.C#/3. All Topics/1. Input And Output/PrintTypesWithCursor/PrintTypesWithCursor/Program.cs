using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTypesWithCursor
{
    class Program
    {
        static void Main(string[] args)
        {
            //print statements
            Console.WriteLine("Hii...");
            Console.WriteLine("My name is ABhishek Kumar");
            /* WriteLine will move the cursor to the next line, after statement is completed. */

            //print statements
            Console.Write("Hii...");
            Console.Write("\n");
            Console.Write("My name is ABhishek Kumar");
            Console.WriteLine("");


            /* Write don't move the cursor to the next line, after statement is completed. */

            
            //Other Options to move cursor to next line
            Console.Write("\n");          //this will move the cursor to the next line
            Console.Write("New Line");    //Starts from new line.
            Console.Write("\n");

            Console.WriteLine("new Line 2");        //this will move the cursor to next line after printing statements.

            Console.WriteLine("new line 3\n");      //with writeLine and \n the curso will move down two times.
            Console.WriteLine("hii...");            //after this print cursor will move down.

            Console.WriteLine("new line 4");      //after print cursor to next line
            Console.Write("hii...\n");            //here write line not push cursor to next line but \n will do
            Console.Write("Line 5");              //in new line but cursor will remain in same line
            Console.WriteLine("");                //pushes the cursor to next line i.e. new line
            Console.WriteLine("Last line.");      //final line then curor to next line
            

            /* alternet Option for line change */
            
            Console.Write("");          //Print - sameline, cursor - sameline
            Console.WriteLine("");      //Print - sameline, cursor - nextline
            Console.Write("\t");        //this is tab help in moving 7 space front.
            Console.Write("");          //cursor - remain same place
            Console.Write("\n");        //cursor - nextline
            Console.Write("\n hii..");  //first cursor to next line then print
            Console.Write("hii..\n ");  //first print then next line.

            Console.WriteLine("");          //cursor - moves to next line
            Console.WriteLine("\n");        //cursor - moves to next line 2 times..  1-\n , 2-with Line
            Console.WriteLine("\n hii..");  //first cursor to next line then print then again cursor to next line
            Console.WriteLine("hii..\n ");  //first print then next cursor to next line using \n then again to next line with Line.
            


            Console.ReadKey();      //Wait for Key Press
        }
    }
}

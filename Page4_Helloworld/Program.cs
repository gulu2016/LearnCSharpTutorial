// C# program to print Hello World!
//s4-1-1-4 System is a namespace which contains the commonly used types.
//It is specified with a using System directive.这里相当于引用其他namespace的内容
using System;

//s4-1-1-3 namespace declaration
namespace HelloWorldApp
{

    // Class declaration
    class Geeks
    {

        // Main Method
        static void Main(string[] args)
        {

            // statement
            //s4-1-1-1 printing Hello World!
            Console.WriteLine("Hello World!");

            //s4-1-1-2 To prevents the screen from
            // running and closing quickly
            Console.ReadKey();
        }
    }
}

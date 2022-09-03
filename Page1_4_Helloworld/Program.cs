// C# program to print Hello World!

//p1-4-s1-4 System is a namespace which contains the commonly used types.
// It is specified with a using System directive.这里相当于引用其他namespace的内容
using System;

//p1-4-s1-3 namespace declaration
namespace HelloWorldApp
{

    // Class declaration
    class Geeks
    {

        // Main Method
        static void Main(string[] args)
        {

            // statement
            //p1-4-s1-1 printing Hello World!
            Console.WriteLine("Hello World!");

            //p1-4-s1-2 To prevents the screen from
            // running and closing quickly
            Console.ReadKey();
        }
    }
}

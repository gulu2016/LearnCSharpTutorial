// C# program to demonstrate the Sbyte
// signed integral data type
using System;
namespace ValueTypeTest
{
    class GeeksforGeeks2
    {

        // Main function
        static void Main_test()
        {
            sbyte a = 126;

            // sbyte is 8 bit
            // singned value
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            // It overflows here because
            // byte can hold values
            // from -128 to 127
            a++;
            Console.WriteLine(a);

            // Looping back within
            // the range
            a++;
            Console.WriteLine(a);
        }
    }
}


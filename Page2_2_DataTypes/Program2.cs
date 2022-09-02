// C# program to demonstrate the Sbyte
// signed integral data type
using System;
namespace ValueTypeTest
{
    class GeeksforGeeks2
    {

        // Main function
        static void Main2()
        {
            sbyte a = 126;

            // sbyte is 8 bit
            // singned value
            Console.WriteLine(a);

            //p2_2-s2-1 sbyte类型是[-128，127]，所以连续增加会溢出
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


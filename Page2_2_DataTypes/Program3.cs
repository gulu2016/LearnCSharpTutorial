// C# program to demonstrate
// the byte data type
using System;
namespace ValueTypeTest
{

    class GeeksforGeeks3
    {

        // Main function
        static void Main3()
        {
            byte a = 0;

            // byte is 8 bit
            // unsigned value
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            a = 254;

            // It overflows here because
            // byte can hold values from
            // 0 to 255
            //p2_2-s3-1 因为byte的范围是[0,255],所以溢出之后的值是0
            a++;
            Console.WriteLine(a);

            // Looping back within the range
            a++;
            Console.WriteLine(a);
        }
    }
}


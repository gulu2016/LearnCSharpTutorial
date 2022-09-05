// C# program to illustrate creating an array
// of integers, puts some values in the array,
// and prints each value to standard output.
using System;
namespace geeksforgeeks
{

    class GFG_p6_1_program1
    {

        // Main Method
        public static void Main_p6_1_program1()
        {

            // declares an Array of integers.
            int[] intArray;

            // allocating memory for 5 integers.
            intArray = new int[5];

            // initialize the first elements
            // of the array
            intArray[0] = 10;

            // initialize the second elements
            // of the array
            intArray[1] = 20;

            // so on...
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            // accessing the elements
            // using for loop
            Console.Write("For loop :");
            //p6_1-s1-1 使用for循环遍历数组
            for (int i = 0; i < intArray.Length; i++)
                Console.Write(" " + intArray[i]);

            Console.WriteLine("");
            Console.Write("For-each loop :");

            // using for-each loop
            //p6_1-s1-2 使用foreach循环遍历数组
            foreach (int i in intArray)
                Console.Write(" " + i);

            Console.WriteLine("");
            Console.Write("while loop :");

            // using while loop
            //p6_1-s1-3 使用while循环遍历数组
            int j = 0;
            while (j < intArray.Length)
            {
                Console.Write(" " + intArray[j]);
                j++;
            }

            Console.WriteLine("");
            Console.Write("Do-while loop :");

            // using do-while loop
            //p6_1-s1-4 使用do-while循环遍历数组
            int k = 0;
            do
            {
                Console.Write(" " + intArray[k]);
                k++;
            } while (k < intArray.Length);
        }
    }
}

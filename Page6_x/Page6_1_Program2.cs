// C# program to single-dimensional jagged array
// that contains two single-dimensional array
// elements of different sizes.
using System;
namespace geeksforgeeks
{

    class GFG_p6_1_program2
    {

        // Main Method
        public static void Main_program3()
        {

            /*----------2D Array---------------*/
            // Declare the array of two elements:
            int[][] arr = new int[2][];

            // Initialize the elements:
            //p6_1-s2-1 定义一个二维数组，数组中包含的数组长度不一样
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Another way of Declare and
            // Initialize of elements
            //p6_1-s2-2 第二种形式给二维数组赋值
            int[][] arr1 = { new int[] { 1, 3, 5, 7, 9 },
                        new int[] { 2, 4, 6, 8 } };

            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element [" + i + "] Array: ");
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Another Array");

            // Display the another array elements:
            for (int i = 0; i < arr1.Length; i++)
            {
                System.Console.Write("Element [" + i + "] Array: ");
                for (int j = 0; j < arr1[i].Length; j++)
                    Console.Write(arr1[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
}

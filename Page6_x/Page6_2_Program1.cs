// C# program to illustrate the Mixing of 1-D
// Jagged Array with the four 2-D array
using System;
namespace geeksforgeeks
{

    class GFG_p6_2_program1
    {

        // Main Method
        public static void Main_p6_2_program1()
        {

            // Declaration and Initialization of
            // Jagged array with 4 2-D arrays
            //p6_2-s1-1 定义包含4行，列数不固定的数组
            //每列中包含不固定个数的二维数组
            int[][,] jagged_arr1 = new int[4][,] {new int[, ] {{1, 3}, {5, 7}},
                                    new int[, ] {{0, 2}, {4, 6}, {8, 10}},
                                    new int[, ] {{7, 8}, {3, 1}, {0, 6}},
                                    new int[, ] {{11, 22}, {99, 88}, {0, 9}}};

            // Display the array elements:
            // Length method returns the number of
            // arrays contained in the jagged array
            //p6_2-s1-2 遍历不定长的多维数组
            for (int i = 0; i < jagged_arr1.Length; i++)
            {

                int x = 0;

                // GetLength method takes integer x which
                // specifies the dimension of the array
                for (int j = 0; j < jagged_arr1[i].GetLength(x); j++)
                {

                    // Rank is used to determine the total
                    // dimensions of an array
                    for (int k = 0; k < jagged_arr1[j].Rank; k++)
                        Console.Write("Jagged_Array[" + i + "][" + j + ", " + k + "]: "
                                                    + jagged_arr1[i][j, k] + " ");
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }
    }
}

// C# program to single-dimensional jagged array
// that contains three two-dimensional array
// elements of different sizes.
using System;
namespace geeksforgeeks
{

    class GFG_p6_1_program3
    {

        // Main Method
        public static void Main_p6_1_program3()
        {
            //p6_1-s3-1 一维数组是[]，只需要一个数字就能找到一个值
            //在以为数组上扩展二维数组是[][]，在找到第一个值的基础上，需要再给一个值，向下确定其深度
            //在[][]基础上，变为[][,]，在确定深度的情况下，找到一个数组，这个数组有固定两个元素
            ////p6_1-s3-2 增加一个[]会增加数组的维数，访问深度加1，“,”增加一个只是增加数组的宽度
            int[][,] arr = new int[3][,] {new int[, ] {{1, 3}, {5, 7}},
                                    new int[, ] {{0, 2}, {4, 6}, {8, 10}},
                                    new int[, ] {{11, 22}, {99, 88}, {0, 9}}};

            
            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < arr[i].GetLength(x); j++)
                {
                    for (int k = 0; k < arr[j].Rank; k++)
                        Console.Write(" arr[" + i + "][" + j + ", " + k + "]:"
                                                    + arr[i][j, k] + " ");
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }
    }
}

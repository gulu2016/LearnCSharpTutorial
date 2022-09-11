// C# program to illustrate the
// Array.Rank Property
using System;
namespace geeksforgeeks
{

    class GFG
    {

        // Main Method
        public static void Main()
        {

            // declaring an 2-D array
            int[,] arr2d = new int[4, 2];

            // declaring an 3-D array
            int[,,] arr3d = new int[4, 2, 3];

            // declaring an jagged array
            int[][] jdarr = new int[2][];

            // using Rank Property
            //p6_5-s5-1 int[,]是二维数组
            Console.WriteLine("Dimension of arr2d array: "
                                            + arr2d.Rank);
            //p6_5-s5-2 int[,,]是三维数组
            Console.WriteLine("Dimension of arr3d array: "
                                            + arr3d.Rank);

            // for the jagged array it
            // will always return 1
            //p6_5-s5-3 int[][] 是一维数组
            Console.WriteLine("Dimension of jdarr array: "
                                            + jdarr.Rank);
        }
    }
}

// C# program to demonstrate the use of the
// Array.Sort<T>(T[ ], Comparison<T>) Method
using System;
using System.Collections.Generic;

class GFG
{

    private static int CompareComp(string x, string y)
    {
        if (y == null && x == null)
        {

            // If x and y is null
            // then x and y are same
            return 0;
        }
        else
        {

            // If x is null but y is not
            // null then y is greater.
            return -1;
        }
    }

    // Main method
    public static void Main_p6_4_program4()
    {
        string[] arr = {"Java", "C++", "Scala",
                        "C", "Ruby", "Python"};

        Console.WriteLine("Original Array: ");

        // display original array
        Display(arr);

        Console.WriteLine("\nSort with Comparison: ");

        // Array.Sort<T>(T[], Comparison<T>)
        // Method
        //p6_4-s4-1 使用自定义的比较器对元素排序，这里CompareComp是一个静态的函数
        Array.Sort(arr, CompareComp);

        // display sorted array
        Display(arr);

    }

    // Display function
    public static void Display(string[] arr)
    {
        foreach (string g in arr)
        {
            Console.WriteLine(g);
        }
    }
}

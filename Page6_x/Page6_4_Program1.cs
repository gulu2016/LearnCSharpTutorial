// C# Program to illustrate the use
// of the Array.Sort<T>(T[]) Method
using System;
using System.Collections.Generic;

class GFG_p6_4_program1
{

    // Main Method
    public static void Main_p6_4_program1()
    {
        // array elements
        string[] arr = new string[5] { "A",
                    "D", "X", "G", "M" };

        foreach (string g in arr)
        {
            Console.WriteLine(g);
            // display original array
        }

        //p6_4-s1-1 普通排序，按照字母表的顺序排列 
        Console.WriteLine("\nAfter Sort:");
        Array.Sort(arr);

        foreach (string g in arr)
        {
            Console.WriteLine(g);
            // display sorted array
        }

    }

}

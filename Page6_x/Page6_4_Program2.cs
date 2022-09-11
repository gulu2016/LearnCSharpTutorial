// C# program to demonstrate the use of the
// Array.Sort<T>(T[], IComparer<T>) method
using System;
using System.Collections.Generic;

public class GeeK : IComparer<string>
{

    public int Compare(string x, string y)
    {
        // Compare x and y in reverse order.
        return x.CompareTo(y);
    }
}

class GFG_p6_4_program2
{

    // Main Method
    public static void Main_p6_4_program2()
    {
        // array elements
        string[] arr = new string[5] {"A",
                    "D", "X", "G", "M" };

        foreach (string g in arr)
        {

            // display original array
            Console.WriteLine(g);
        }

        Console.WriteLine("\nAfter Sort: ");
        GeeK gg = new GeeK();

        // Sort<T>(T[], IComparer<T>) method
        //p6_4-s2-1 比较的时候传入比较器，比较器是重写IComparer<string>接口的GeeK类的实例
        Array.Sort(arr, gg);

        foreach (string g in arr)
        {
            // display sorted array
            Console.WriteLine(g);
        }

        Console.WriteLine("\nD Sorts between :");
    }
}

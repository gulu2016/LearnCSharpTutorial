// C# program to demonstrate the use of
// Array.Sort<T>(T[], Int32, Int32) method
using System;
using System.Collections.Generic;

public class Geek : IComparer<string>
{

    //p6_4-s3-1 比较器使用逆序的顺序排序
    public int Compare(string x, string y)
    {
        // Compare y and x in reverse order.
        return y.CompareTo(x);
    }
}

public class Example
{

    // Main Method
    public static void Main_p6_4_program3()
    {
        // Array elements
        string[] arr = {"AB", "CD",
        "GH", "EF", "MN", "IJ"};

        Console.WriteLine("Original Array :");

        Display(arr);

        Console.WriteLine("\nSort the array between " +
                                    "index 1 to 4");

        // Array.Sort(T[], Int32, Int32) method
        // sort will happen in between
        // index 1 to 4
        //p6_4-s3-2 按照字母表的顺序对下标【0，3】的元素排序
        Array.Sort(arr, 0, 4);
        Display(arr);

        Console.WriteLine("\nSort the array reversely" +
                        " in between index 1 to 4");

        // sort will happen in between
        // index 1 to 4 reversely		
        //p6_4-s3-3 按照字母表的逆序顺序对下标【0，3】的元素排序
        Array.Sort(arr, 0, 4, new Geek());

        Display(arr);
    }

    public static void Display(string[] arr)
    {
        foreach (string g in arr)
        {
            Console.WriteLine(g);
        }
    }
}

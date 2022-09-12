// C# code to remove a range of
// elements from the ArrayList
using System;
using System.Collections;
using System.Collections.Generic;

class GFG
{

    // Driver code
    public static void Main()
    {

        // Creating an ArrayList
        ArrayList myList = new ArrayList(10);

        // Adding elements to ArrayList
        myList.Add(2);
        myList.Add(4);
        myList.Add(6);
        myList.Add(8);
        myList.Add(10);
        myList.Add(12);
        myList.Add(14);
        myList.Add(16);
        myList.Add(18);
        myList.Add(20);

        // Displaying the elements in ArrayList
        Console.WriteLine("The initial ArrayList: ");

        foreach (int i in myList)
        {
            Console.WriteLine(i);
        }

        //p7_2-s1-1 removing 4 elements starting from index 0
        myList.RemoveRange(0, 4);

        //p7_2-s1-2 判断myList是否有12这个元素
        myList.Contains(12);

        // Displaying the modified ArrayList
        Console.WriteLine("The ArrayList after Removing elements: ");

        // Displaying the elements in ArrayList
        foreach (int i in myList)
        {
            Console.WriteLine(i);
        }
    }
}

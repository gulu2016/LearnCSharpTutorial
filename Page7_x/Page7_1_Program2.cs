// C# program to illustrate
// sorting of ArrayList
using System;
using System.Collections;

public class GFG_p7_1_program2
{
    static public void Main_p7_1_program2()
    {

        // Creating ArrayList
        ArrayList My_array = new ArrayList();

        // Adding elements in the
        // My_array ArrayList
        // This ArrayList contains
        // elements of the same types
        My_array.Add(1);
        My_array.Add(6);
        My_array.Add(40);
        My_array.Add(10);
        My_array.Add(5);
        My_array.Add(3);
        My_array.Add(2);
        My_array.Add(4);

        // ArrayList before sorting
        Console.WriteLine("ArrayList before using Sort() method:");

        foreach (var elements in My_array)
        {
            Console.WriteLine(elements);
        }

        // Sort the elements of the ArrayList
        // Using sort() method
        //p7_1-s2-1 对ArrayList中的元素进行排序
        My_array.Sort();

        // ArrayList after sorting
        Console.WriteLine("ArrayList after using Sort() method:");
        foreach (var elements in My_array)
        {
            Console.WriteLine(elements);
        }
    }
}

// C# program to illustrate nested tuple
using System;

public class GFG_p9_1_program2
{

    // Main method
    static public void Main_p9_1_program2()
    {

        // Nested Tuple
        // Here nested tuple is present
        // at the place of 2nd element
        var My_Tuple = Tuple.Create(13, Tuple.Create(12, 30, 40,
                            50), 67, 89.90, 'g', 39939, 123, "geeks");

        // Accessing the element of Tuple
        // Using Item property
        // And accessing the elements of
        // nested tuple Using Rest property
        //p9_1-s2-1 如果Tuple中有Tuple，那么按照My_Tuple.Item2.Item1格式访问嵌套的Tuple元素
        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item1);
        Console.WriteLine("Element of Nested Tuple: " + My_Tuple.Item2.Item1);
        Console.WriteLine("Element of Nested Tuple: " + My_Tuple.Item2.Item2);
        Console.WriteLine("Element of Nested Tuple: " + My_Tuple.Item2.Item3);
        Console.WriteLine("Element of Nested Tuple: " + My_Tuple.Item2.Item4);
        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item3);
        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item4);
        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item5);
        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item6);
        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item7);
        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Rest);




        // Nested Tuple
        var My_Tuple1 = Tuple.Create(13, "Geeks", 67, 89.90,
                 'g', 39939, "geek", Tuple.Create(12, 30, 40, 50));

        // Accessing the element of Tuple
        // Using Item property
        // And accessing the elements of nested tuple
        // Using Rest property
        //p9_1-s2-2 如果嵌套的Tuple在末尾，那么需要通过My_Tuple1.Rest.Item1.Item1的格式访问
        Console.WriteLine("Element of My_Tuple: " + My_Tuple1.Item1);
        Console.WriteLine("Element of My_Tuple: " + My_Tuple1.Item2);
        Console.WriteLine("Element of My_Tuple: " + My_Tuple1.Item3);
        Console.WriteLine("Element of My_Tuple: " + My_Tuple1.Item4);
        Console.WriteLine("Element of My_Tuple: " + My_Tuple1.Item5);
        Console.WriteLine("Element of My_Tuple: " + My_Tuple1.Item6);
        Console.WriteLine("Element of My_Tuple: " + My_Tuple1.Item7);
        Console.WriteLine("Element of Nested tuple: " + My_Tuple1.Rest);
        Console.WriteLine("Element of Nested tuple: " + My_Tuple1.Rest.Item1.Item1);
        Console.WriteLine("Element of Nested tuple: " + My_Tuple1.Rest.Item1.Item2);
        Console.WriteLine("Element of Nested tuple: " + My_Tuple1.Rest.Item1.Item3);
        Console.WriteLine("Element of Nested tuple: " + My_Tuple1.Rest.Item1.Item4);

    }
}

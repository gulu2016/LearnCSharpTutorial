// C# program to demonstrate the ArrayList
using System;
using System.Collections;

class GFG_p7_1_program1
{

    // Main Method
    static public void Main_p7_1_program1()
    {

        // Creating ArrayList
        //p7_1-s1-1 创建一个ArrayList
        ArrayList My_array = new ArrayList();

        // Adding elements in the
        // My_array ArrayList
        // This ArrayList contains elements
        // of different types
        //p7_1-s1-2 向ArrayList中添加元素
        My_array.Add(12.56);
        My_array.Add("GeeksforGeeks");
        My_array.Add(null);
        My_array.Add('G');
        My_array.Add(1234);
        My_array.Add(12.56);
        My_array.Add("GeeksforGeeks");
        My_array.Add(null);
        My_array.Add('G');
        My_array.Add(1234);

        // Accessing the elements
        // of My_array ArrayList
        // Using foreach loop
        //p7_1-s1-3 遍历ArrayList的元素
        foreach (var elements in My_array)
        {
            Console.WriteLine(elements);
        }


        // Displaying count of elements of ArrayList
        //p7_1-s1-4 Count返回ArrayList中的元素个数
        Console.WriteLine("Number of elements: " + My_array.Count);

        // Displaying Current capacity of ArrayList
        //p7_1-s1-5 Capacity返回ArrayList中的容量大小
        Console.WriteLine("Current capacity: " + My_array.Capacity);
    }
}

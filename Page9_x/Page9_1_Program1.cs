// C# program to create tuple using tuple constructor.
using System;

public class GFG_p9_1_program1
{

    // Main method
    static public void Main_p9_1_program1()
    {

        // Tuple with one element
        //p9_1-s1-1 定义包含一个元素的Tuple
        Tuple<string> My_Tuple1 = new Tuple<string>("GeeksforGeeks");

        // Tuple with three elements
        //p9_1-s1-2 定义包含三个元素的Tuple
        Tuple<string, string, int> My_Tuple2 = new Tuple<string, string, int>("Romil", "Python", 29);

        // Tuple with eight elements
        //p9_1-s1-3 定义包含8个元素的Tuple，最多也只能有8个元素
        Tuple<int, int, int, int, int, int, int, Tuple<int>> My_Tuple3 = new Tuple<int, int, int, int, int, int, int, Tuple<int>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int>(8));

        // Creating 1-tuple
        // Using Create Method
        //p9_1-s1-4 使用Create方法创建Tuple,这种方式创建的时候不需要指定数据类型，但是要赋值
        var My_Tuple4 = Tuple.Create("GeeksforGeeks");

        // Creating 4-tuple
        // Using Create Method
        var My_Tuple5 = Tuple.Create(12, 30, 40, 50);

        // Creating 8-tuple
        // Using Create Method
        var My_Tuple6 = Tuple.Create(13, "Geeks", 67,
                      89.90, 'g', 39939, "geek", 10);


        // Creating 8-tuple
        // Using Create Method
        var My_Tuple7 = Tuple.Create(13, "Geeks",
              67, 89.90, 'g', 39939, "geek", 10);

        // Accessing the element of Tuple
        // Using Item property
        // And print the 8th element of tuple
        // using Rest property
        //p9_1-s1-5 通过Item1访问Tuple的第一个元素，其他的类似
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple7.Item1);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple7.Item2);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple7.Item3);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple7.Item4);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple7.Item5);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple7.Item6);
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple7.Item7);
        //p9_1-s1-6 对于第7个元素之后的元素，使用Rest属性访问
        Console.WriteLine("Element of My_Tuple3: " + My_Tuple7.Rest);

    }
}

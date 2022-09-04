// C# program to illustrate the
// concept of ref parameter
using System;

class GFG2
{

    // Main Method
    public static void Main2()
    {

        // Assigning value
        string val = "Dog";

        //p5_3-s2-2 调用函数时候需要显示使用ref关键字声明使用的是引用类型的参数
        // Pass as a reference parameter
        CompareValue(ref val);

        //p5_3-s2-3 在函数中的改变会带到函数外
        // Display the given value
        Console.WriteLine(val);
    }

    //p5_3-s2-1定义函数的时候，参数列表中有ref关键字，表示是引用类型的参数
    static void CompareValue(ref string val1)
    {
        // Compare the value
        if (val1 == "Dog")
        {
            Console.WriteLine("Matched!");
        }

        // Assigning new value
        val1 = "Cat";
    }
}

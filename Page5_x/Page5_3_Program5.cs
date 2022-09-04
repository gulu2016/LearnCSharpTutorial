// C# program to illustrate the concept
// of the dynamic parameters
using System;

class GFG5
{

    // Method which contains dynamic parameter
    //p5_3-s5-1 动态参数在定义时候不确定类型，使用dynamic关键字
    public static void mulval(dynamic val)
    {
        val *= val;
        Console.WriteLine(val);
    }

    // Main method
    static public void Main5()
    {
        //p5_3-s5-2 使用动态参数的时候，都是调用的时候传入值，函数根据运行时候传入的值确定参数类型
        // Calling mulval method
        mulval(30);
    }
}

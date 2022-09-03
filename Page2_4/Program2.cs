// C# program to illustrate the use of
// floating-point literals
using System;

class Geeks2
{

    // Main Method
    public static void Main2(String[] args)
    {
        // decimal-form literal
        //p2_4-s2-1 使用浮点数的字面量
        double a = 101.230;

        // It also acts as decimal literal
        //p2_4-s2-2 默认是double的，如果要给float类型赋值，需要末尾加上f
        float b = 123.222f;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}


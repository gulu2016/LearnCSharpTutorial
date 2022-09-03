// C# program to illustrate the use of Integer Literals
using System;

class Geeks1
{

    // Main method
    public static void Main1(String[] args)
    {

        // decimal-form literal
        //p2_4-s1-1 101是十进制常量
        int a = 101;

        // octal-form literal
        //p2_4-s1-2 0145是8进制常量，感觉这里有问题，即使有9也没有报错
        int b = 01459;

        // Hexa-decimal form literal
        //p2_4-s1-3 0xFace是16进制常量
        int c = 0xFace;

        // binary-form literal
        //p2_4-s1-4 0b101是2进制常量
        int x = 0b101;

        //p2_4-s1-5 最后输出时候都是按照10进制输出的
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(x);
    }
}

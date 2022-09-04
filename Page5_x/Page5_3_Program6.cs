// C# program to illustrate value parameters
using System;

public class GFG6
{

    // Main Method
    static public void Main6()
    {

        // The value of the parameter
        // is already assigned
        //p5_3-s6-1 值类型的参数，传递给函数之后，在函数内的改变不会影响函数外的值
        string str1 = "Geeks";
        string str2 = "geeks";
        string res = addstr(str1, str2);
        Console.WriteLine("res = "+res);
        Console.WriteLine("str1 = "+str1);
        Console.WriteLine("str2 = "+str2);
    }

    public static string addstr(string s1, string s2)
    {
        //p5_3-s6-2 函数内改变参数的值在函数外边不会体现
        string a = s1;
        string b = s2;
        s1 += "aaa";
        s2 += "bbb";
        return a + b;
    }
}

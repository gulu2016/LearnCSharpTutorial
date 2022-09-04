// C# program to illustrate the
// concept of the named parameters
using System;

public class GFG1
{

    // addstr contain three parameters
    public static void addstr(string s1, string s2, string s3)
    {
        string result = s1 + s2 + s3;
        Console.WriteLine("Final string is: " + result);
    }

    // Main Method
    static public void Main1()
    {
        // calling the static method with named
        // parameters without any order
        //p5_3-s1-1 调用函数的时候，通过参数的名称给函数传参
        addstr(s1: "Geeks", s2: "for", s3: "Geeks");
        //p5_3-s1-2 如果和位置参数混用，会先考虑位置参数，所以感觉这个方式意义不大
        //addstr("Geeks", "Geeks",s2: "for");
    }
}

// C# program to illustrate
// the use of @ in terms of
// escape sequences and new
// line and tab
using System;

public class GFG
{

    // Main method
    static public void Main()
    {

        // If you use the below commented
        // the part then this will give
        // Unrecognized escape sequence error
        //p8_2-s1-1 这里会报错，因为\+空格无法转义
        //string S1 = "\\welcome \to GeeksforGeeks \ portal \";
        // Console.WriteLine("String 1 is :{0}", S1);

        // By using @ in the given string
        // it runs smoothly because
        // @ symbol tells the compiler to
        // ignore all escape sequences
        //p8_2-s1-2 有了@会将字符串中的转义字符都失效，S2会正常打印
        string S2 = @"\\welcome \to GeeksforGeeks \ portal \";
        Console.WriteLine("String 2 is: {0}", S2);

        // printing new line character in string literal
        // but it will make the string to break
        // into a new line, see output
        //p8_2-s1-3 这里\n会正常换行
        string S3 = "This is \n C# non verbatim string";
        Console.WriteLine("String 3 is :{0}", S3);

        // By using @ symbol /n does not processed
        //p8_2-s1-4 有了@会让转义字符串失效，\n就直接打印为"\n"
        string S4 = @"This is \n C# verbatim string";
        Console.WriteLine("String 4 is :{0}", S4);

        // printing a string literal contains
        // tabs and new line without using
        // any escape sequence
        //p8_2-s1-5 这个字符串中没有转义字符，同时占用了两行，中间有些tab字符，都会打印出来
        //只要不是通过转义字符控制的都会被打印出来
        Console.WriteLine(@"Without Tab Sequence and New Line Character
							C		 C++	 Java	 Python");
    }
}

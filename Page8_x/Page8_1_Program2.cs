// C# program to demonstrate the
// string creation using literals
using System;
class Geeks_p8_1_program2
{

    // Main Method
    static void Main_p8_1_program2(string[] args)
    {
        string str1 = "GeeksforGeeks";
        Console.WriteLine(str1);

        // Give Error Unrecognized escape sequence \H, \G, \p
        // string str3 = "X:\Home\GFG\Geeks.cs";
        // Console.WriteLine(str3);

        // using double slash \\
        //p8_1-s2-1 \\打印出来就变成了\，因为前一个\是转义字符
        string str2 = "X:\\Home\\GFG\\program.cs";
        Console.WriteLine(str2);

    }
}

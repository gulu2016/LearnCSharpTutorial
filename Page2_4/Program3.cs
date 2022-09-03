// C# program to illustrate the use of char literals
using System;

class Geeks3
{

    // Main Method
    public static void Main3(String[] args)
    {

        // character literal within single quote
        //p2_4-s3-1 普通字符
        char ch = 'a';

        // Unicode representation
        //p2_4-s3-2 使用\u+4位十进制数字表示的编码字符，这里表示的也是a
        char c = '\u0061';

        Console.WriteLine(ch);
        Console.WriteLine(c);

        // Escape character literal
        //p2_4-s3-3 \n表示换行，是转义字符
        Console.WriteLine("Hello\n\nGeeks\t!");
    }
}

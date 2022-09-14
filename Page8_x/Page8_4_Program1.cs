// C# program to demonstrate the
// StringBuilder.Append(value) and
// StringBuilder.AppendLine(value) method
using System;
using System.Text;

class GFG
{

    // Main Method
    public static void Main()
    {

        // "20" is capacity
        //p8_4-s1-1 这里第二个参数是建议的初始容量
        StringBuilder s = new StringBuilder("HELLddd ", 20);
        //p8_4-s1-2 在字符串末尾追加内容
        s.Append("GFG");

        // after printing "GEEKS"
        // a new line append
        //p8_4-s1-3 追加内容之后会换行
        s.AppendLine("GEEKS");

        s.Append("GeeksForGeeks");
        Console.WriteLine(s);

        //p8_4-s1-4 向指定位置插入内容
        s.Insert(6, "GEEKS");
        Console.WriteLine(s);

        //p8_4-s1-5 从指定位置删除指定长度的字符串
        s.Remove(5, 3);
        Console.WriteLine(s);

        //p8_4-s1-6 替换字符串中的内容
        s.Replace("GFG", "Geeks For");
        Console.WriteLine(s);
    }
}

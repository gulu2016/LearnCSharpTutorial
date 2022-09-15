// C# program to illustrated named member
using System;

public class GFG
{
    static public void Main()
    {
        //p9_3-s1-1 使用括号的方式创建ValueTuple
        (int age, string Aname, string Lang) author = (23, "Sonia", "C#");
        //p9_3-s1-2 使用括号的方式创建ValueTuple,另一种格式
        var author2 = (age: 23, Aname
                      : "Sonia", Lang
                      : "C#");

        //p9_3-s1-3 使用括号的方式创建ValueTuple，这里没有给Tuple中的元素命名
        var author3 = (20, "Siya", "Ruby");

        //p9_3-s1-4 没有给Tuple中的元素命名，但是定义了类型
        ValueTuple<int, string, string> author4 = (20, "Siya", "Ruby");

        //p9_3-s1-5 第一种访问ValueTuple的方式，相当于使用位置来访问
        Console.WriteLine("Age:" + author.Item1);
        Console.WriteLine("Name:" + author.Item2);
        Console.WriteLine("Language:" + author.Item3);

        //p9_3-s1-6 第二种访问ValueTuple的方式，相当于使用属性名来访问
        Console.WriteLine("Book Id: {0}", author2.age);
        Console.WriteLine("Author Name: {0}", author2.Aname);
        Console.WriteLine("Book Name: {0}", author2.Lang);
    }
}

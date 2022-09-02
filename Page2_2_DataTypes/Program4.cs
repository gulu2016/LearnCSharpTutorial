// C# program to demonstrate
// the Reference data types
using System;
namespace ValueTypeTest
{

    class GeeksforGeeks4
    {

        // Main Function
        static void Main()
        {

            // declaring string
            string a = "Geeks";

            //append in a
            //p2_2-s4-1 使用+连接字符串 
            a += "for";
            a = a + "Geeks";
            Console.WriteLine(a);

            // declare object obj
            //p2_2-s4-2 这里给Object类直接赋值一个int，利用了自动装箱
            object obj;
            obj = 20;
            Console.WriteLine(obj);

            // to show type of object
            // using GetType()
            //p2_2-s4-3 使用GetType()获取obj对象的类型
            //q2_2-s4-4 为什么这里的obj是Int32类型？不应该是装箱成Object了吗？
            Console.WriteLine(obj.GetType());
        }
    }
}

// C# Program to illustrate calling
// a Default constructor
using System;
namespace DefaultConstructorExample
{

    class Geek1
    {

        int num;
        string name;

        // this would be invoked while the
        // object of that class created.
        //p4_2-s1-1 默认构造器，没有参数
        Geek1()
        {
            Console.WriteLine("Constructor Called");
        }

        // Main Method
        public static void Main1()
        {

            // this would invoke default
            // constructor.
            Geek1 geek1 = new Geek1();

            // Default constructor provides
            // the default values to the
            // int and object as 0, null
            // Note:
            // It Give Warning because
            // Fields are not assign
            //p4_2-s1-2 默认构造器会将数字初始化为0，将字符串初始化为null
            Console.WriteLine(geek1.name);
            Console.WriteLine(geek1.num);
        }
    }
}

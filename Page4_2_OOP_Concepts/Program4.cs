// C# Program to illustrate calling
// a Static constructor
using System;
namespace staticConstructorExample
{

    class geeks
    {

        // It is invoked before the first
        // instance constructor is run.
        //p4_2-s4-1 静态构造器在类初始化的之后执行一次，并且只执行一次
        //p4_2-s4-2 静态构造器只能初始化静态的属性
        static geeks()
        {

            // The following statement produces
            // the first line of output,
            // and the line occurs only once.
            Console.WriteLine("Static Constructor");
        }

        // Instance constructor.
        public geeks(int i)
        {
            Console.WriteLine("Instance Constructor " + i);
        }

        // Instance method.
        public string geeks_detail(string name, int id)
        {
            return "Name:" + name + " id:" + id;
        }

        // Main Method
        public static void Main()
        {

            // Here Both Static and instance
            // constructors are invoked for
            // first instance
            //p4_2-s4-3 对于第一个创建的对象，会先执行静态构造器初始化静态属性
            //再执行构造器初始化动态的属性
            geeks obj = new geeks(1);

            Console.WriteLine(obj.geeks_detail("GFG", 1));

            // Here only instance constructor
            // will be invoked
            //p4_2-s4-4 这里第二个创建的对象就只执行普通的构造器了，静态构造器只执行一次
            geeks obj1 = new geeks(2);

            Console.WriteLine(obj1.geeks_detail("GeeksforGeeks", 2));
        }
    }
}

// C# program to calculate the area
// of a square using the concept of
// data abstraction
using System;

namespace Demoabstraction
{

    // abstract class
    //p4_5-s1-1 定义抽象类，抽象类中有抽象方法
    abstract class Shape
    {

        // abstract method
        public abstract int area();
    }

    // square class inheriting
    // the Shape class
    //p4_5-s1-2 定义抽象类的实现类，还是使用：实现
    class Square : Shape
    {

        // private data member
        private int side;

        // method of square class
        public Square(int x = 0)
        {
            side = x;
        }

        // overriding of the abstract method of Shape
        // class using the override keyword
        //p4_5-s1-3 重写抽象类的抽象方法
        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }

    // Driver Class
    class GFG
    {

        // Main Method
        static void Main(string[] args)
        {

            // creating reference of Shape class
            // which refer to Square class instance
            //p4_5-s1-4 定义抽象类的变量，实例化的对象是具体的实现类
            Shape sh = new Square(4);

            // calling the method
            //p4_5-s1-5 调用实现类重写的方法
            double result = sh.area();

            Console.Write("{0}", result);

        }
    }
}

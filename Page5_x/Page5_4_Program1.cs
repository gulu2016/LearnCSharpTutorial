// C# program to demonstrate the method overriding
// without using 'virtual' and 'override' modifiers
using System;

// base class name 'baseClass'
class baseClass1

{
    public void show()
    {
        Console.WriteLine("Base class");
    }
}

// derived class name 'derived'
// 'baseClass' inherit here
class derived1 : baseClass1
{

    // overriding
    //p5_4-s1-1 重写父类的方法，父类不带virtual,子类不带override关键字
    new public void show()
    {
        Console.WriteLine("Derived class");
    }
}

class GFG_p5_4_Program1
{

    // Main Method
    public static void Main_p5_4_Program1()
    {

        // 'obj' is the object of
        // class 'baseClass'
        //p5_4-s1-2 父类引用父类的对象，正常输出父类内容
        baseClass1 obj = new baseClass1();


        // invokes the method 'show()'
        // of class 'baseClass'
        obj.show();
        //p5_4-s1-3 父类引用子类的对象，但是因为没有virtual和override关键字，所以还是调用父类方法
        obj = new derived1();

        // it also invokes the method
        // 'show()' of class 'baseClass'
        obj.show();

    }
}

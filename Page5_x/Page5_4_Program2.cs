// C# program to illustrate the use of
//'virtual' and 'override' modifiers
using System;

class baseClass
{

    // show() is 'virtual' here
    //p5_4-s2-1 父类的方法带有virtual关键字，表示可以被重写
    public virtual void show()
    {
        Console.WriteLine("Base class");
    }
}


// class 'baseClass' inherit
// class 'derived'
class derived : baseClass
{

    //'show()' is 'override' here
    //p5_4-s2-2 子类的方法带有override关键字，表示重写父类的方法
    public override void show()
    {
        Console.WriteLine("Derived class");
    }
}

class GFG_p5_4_Program2
{

    // Main Method
    public static void Main_p5_4_Program2()
    {

        baseClass obj;

        // 'obj' is the object
        // of class 'baseClass'
        //p5_4-s2-3 父类引用指向父类的对象，正常调用父类的方法
        obj = new baseClass();

        // it invokes 'show()'
        // of class 'baseClass'
        obj.show();


        // the same object 'obj' is now
        // the object of class 'derived'
        //p5_4-s2-4 父类的引用指向子类的对象，因为有了virtual和override关键字，所以这次调用子类的方法
        obj = new derived();

        // it invokes 'show()' of class 'derived'
        // 'show()' of class 'derived' is overridden
        // for 'override' modifier
        obj.show();

    }
}

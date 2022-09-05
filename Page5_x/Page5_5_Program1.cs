// C# program to illustrate how to
// create an anonymous function
using System;

class GFG_page5_5_program1
{
    //p5_5-s1-1 使用delegate定一个匿名的函数，返回值和参数列表是固定的
    public delegate void petanim(string pet);

    // Main method
    static public void Main_page5_5_program1()
    {
        string fav = "Rabbit";

        // An anonymous method with one parameter
        //p5_5-s1-2 定义匿名函数的方法体
        petanim p = delegate (string mypet)
        {
            Console.WriteLine("My favorite pet is: {0}",
                                                mypet);

            // Accessing variable defined
            // outside the anonymous function
            //p5_5-s1-3 p可以当作Main函数中的对象，所以这里可以访问 Main函数中的局部变量
            Console.WriteLine("And I like {0} also.", fav);
        };
        p("Dog");
    }
}

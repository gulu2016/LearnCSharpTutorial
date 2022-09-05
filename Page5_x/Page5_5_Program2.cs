// C# program to illustrate how an
// anonymous method passed as a parameter
using System;

public delegate void Show(string x);

class GFG
{

    // identity method with two parameters
    //p5_5-s2-1 定义一个接收匿名函数的函数，Show就是匿名函数的类型
    public static void identity(Show mypet,
                            string color)
    {
        color = " Black" + color;
        mypet(color);
    }

    // Main method
    static public void Main()
    {

        // Here anonymous method pass as
        // a parameter in identity method
        //p5_5-s2-2 调用identity的时候传入一个匿名函数
        identity(delegate (string color) {
            Console.WriteLine("The color" +
            " of my dog is {0}", color);
        },
                                "White");
    }
}

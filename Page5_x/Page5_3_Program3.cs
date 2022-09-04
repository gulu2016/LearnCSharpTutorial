// C# program to illustrate the
// concept of out parameter
using System;

class GFG3
{

    // Main method
    static public void Main3()
    {

        // Creating variable
        // without assigning value
        int num;

        // Pass variable num to the method
        // using out keyword
        //p5_3-s3-2 调用函数的时候使用out关键字
        AddNum(out num);

        // Display the value of num
        Console.WriteLine("The sum of"
        + " the value is: {0}", num);

    }

    // Method in which out parameter is passed
    // and this method returns the value of
    // the passed parameter
    //p5_3-s3-1 使用out关键字定义外部参数，该参数在函数结束的时候会将值保留
    public static void AddNum(out int num)
    {
        num = 40;
        num += num;
    }
}

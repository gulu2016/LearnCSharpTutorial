// C# program to illustrate encapsulation
using System;

public class DemoEncap
{

    // private variables declared
    // these can only be accessed by
    // public methods of class
    //p4_4-s1-1 声明属性都是private类型的
    private String studentName;
    private int studentAge;

    // using accessors to get and
    // set the value of studentName
    //p4_4-s1-2 为属性定义一个accessors，就是封装get和set方法
    public String Name
    {

        get
        {
            return studentName;
        }

        set
        {
            studentName = value;
        }

    }

    // using accessors to get and
    // set the value of studentAge
    public int Age
    {

        get
        {
            return studentAge;
        }

        set
        {
            studentAge = value;
        }

    }


}

// Driver Class
class GFG
{

    // Main Method
    static public void Main()
    {

        // creating object
        DemoEncap obj = new DemoEncap();

        // calls set accessor of the property Name,
        // and pass "Ankita" as value of the
        // standard field 'value'
        //p4_4-s1-3 使用accsser为属性设置值，这里其实是调用accessor的set方法
        obj.Name = "Ankita";

        // calls set accessor of the property Age,
        // and pass "21" as value of the
        // standard field 'value'
        obj.Age = 21;

        // Displaying values of the variables
        //p4_4-s1-4 使用accsser读取属性的值，这里其实调用的是accessor的get方法
        Console.WriteLine("Name: " + obj.Name);
        Console.WriteLine("Age: " + obj.Age);
    }
}

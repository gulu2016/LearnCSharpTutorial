// C# program to illustrate the
// read and write property
using System;

public class Student
{

    // Declare name field
    private string name = "GeeksforGeeks";

    // Declare name property
    //p11_1-s1-1 带有get和 set的property
    public string Name
    {

        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }
}

class TestStudent
{

    // Main Method
    public static void Main(string[] args)
    {
        Student s = new Student();

        // calls set accessor of the property Name,
        // and pass "GFG" as value of the
        // standard field 'value'.
        //p11_1-s1-2 使用set方法赋值
        s.Name = "GFG";

        // displays GFG, Calls the get accessor
        // of the property Name.
        //p11_1-s1-3 使用get方法读取属性值
        Console.WriteLine("Name: " + s.Name);
    }
}

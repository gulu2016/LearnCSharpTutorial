// C# program to illustrate the
// concept of optional parameters
using System;

class GFG4
{

    // This method contains two regular
    // parameters, i.e. ename and eid
    // And two optional parameters, i.e.
    // bgrp and dept
    //p5_3-s4-1 带有默认参数的函数，默认参数都在参数列表的末尾
    static public void detail(string ename,
                            int eid,
                            string bgrp = "A+",
                    string dept = "Review-Team")

    {
        Console.WriteLine("Employee name: {0}", ename);
        Console.WriteLine("Employee ID: {0}", eid);
        Console.WriteLine("Blood Group: {0}", bgrp);
        Console.WriteLine("Department: {0}", dept);
    }

    // Main Method
    static public void Main4()
    {

        // Calling the detail method
        //p5_3-s4-2 调用带有默认参数的函数，后两个参数可以传递，可以不传递
        detail("XYZ", 123);
        detail("ABC", 456, "B-");
        detail("DEF", 789, "B+",
        "Software Developer");
    }
}

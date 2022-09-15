// C# program to demonstrate the
// conversion from String to StringBuilder.
using System;
using System.Text;

class GFG
{

    // Main Method
    public static void Main(String[] args)
    {
        String str = "Geeks";

        // conversion from String object
        // to StringBuilder
        //p8_5-s1-1 将string转化为StringBuilder
        StringBuilder sbl = new StringBuilder(str);
        sbl.Append("ForGeeks");
        Console.WriteLine(sbl);

        //p8_5-s1-2 将StringBuilder转化为string
        Console.WriteLine(sbl.ToString());
    }
}

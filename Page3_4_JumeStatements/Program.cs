// C# Program to illustrate the use
// of throw keyword
using System;

class Geeks
{

    // taking null in the string
    static string sub = null;

    // method to display subject name
    static void displaysubject(string sub1)
    {
        if (sub1 == null)
            //p3_4-s1-1 使用throw抛出异常
            throw new NullReferenceException("Exception Message dddd");

    }

    // Main Method
    static void Main(string[] args)
    {

        // using try catch block to
        // handle the Exception
        try
        {

            // calling the static method
            displaysubject(sub);
        }

        catch (Exception exp)
        {
            Console.WriteLine(exp.Message);
        }
    }

}

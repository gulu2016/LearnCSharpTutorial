// C# program to illustrate the Indexer
using System;

// class declaration
class IndexerCreation
{

    // class members
    private string[] val = new string[3];

    // Indexer declaration
    // public - access modifier
    // string - the return type of the Indexer
    // this - is the keyword having a parameters list
    //p10_1-s1-1 定义Indexer
    public string this[int index]
    {

        // get Accessor
        // retrieving the values
        // stored in val[] array
        // of strings
        //p10_1-s1-2 定义其中的get方法，获取类中的属性的值
        get
        {

            return val[index];
        }

        // set Accessor
        // setting the value at
        // passed index of val
        //p10_1-s1-3 定义其中的set方法，对类中的属性赋值，这里value是关键字，是代表赋值的内容
        set
        {

            // value keyword is used
            // to define the value
            // being assigned by the
            // set indexer.
            val[index] = value;
        }
    }
}

// Driver Class
class main
{

    // Main Method
    public static void Main()
    {

        // creating an object of parent class which
        // acts as primary address for using Indexer
        IndexerCreation ic = new IndexerCreation();

        // Inserting values in ic[]
        // Here we are using the object
        // of class as an array
        //p10_1-s1-4 表面上是使用数组形式，实际上是调用set方法
        ic[0] = "C";
        ic[1] = "CPP";
        ic[2] = "CSHARP";

        Console.Write("Printing values stored in objects used as arrays\n");

        // printing values
        //p10_1-s1-5 表面上是使用数组形式，实际上是调用get方法
        Console.WriteLine("First value = {0}", ic[0]);
        Console.WriteLine("Second value = {0}", ic[1]);
        Console.WriteLine("Third value = {0}", ic[2]);

    }
}

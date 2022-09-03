// C# program to illustrate the
// concept of inheritance
using System;
namespace ConsoleApplication1
{

    // Base class
    //p4_2-s5-1 父类的定义
    class GFG
    {

        // data members
        public string name;
        public string subject;

        // public method of base class
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }

    // inheriting the GFG class using :
    //p4_2-s5-2 使用:继承父类
    class GeeksforGeeks : GFG
    {

        // constructor of derived class
        public GeeksforGeeks()
        {
            Console.WriteLine("GeeksforGeeks");
        }
    }

    // Driver class
    class Sudo
    {

        // Main Method
        static void Main(string[] args)
        {

            // creating object of derived class
            //p4_2-s5-3 定义子类GeeksforGeeks的对象
            GeeksforGeeks g = new GeeksforGeeks();

            // calling the method of base class
            // using the derived class object
            //p4_2-s5-4 子类继承了父类的方法，所以子类对象可以调用父类中的方法
            g.readers("Kirti", "C#");
        }
    }
}

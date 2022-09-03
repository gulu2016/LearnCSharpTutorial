// C# Program to illustrate calling
// a Copy constructor
using System;
namespace copyConstructorExample
{

    class Geeks
    {

        private string month;
        private int year;

        // declaring Copy constructor
        //p4_2-s2-1 创建一个拷贝构造器
        public Geeks(Geeks s)
        {
            month = s.month;
            year = s.year;
        }

        // Instance constructor
        public Geeks(string month, int year)
        {
            this.month = month;
            this.year = year;
        }

        // Get details of Geeks
        //p4_2-s2-2 这里的Details为什么没有参数？
        //get是什么意思
        public string Details
        {
            get
            {
                return "Month: " + month.ToString() +
                        "\nYear: " + year.ToString();
            }
        }

        // Main Method
        public static void Main2()
        {

            // Create a new Geeks object.
            Geeks g1 = new Geeks("June", 2018);

            // here is g1 details is copied to g2.
            //p4_2-s2-3 利用拷贝构造器创建一个新对象
            Geeks g2 = new Geeks(g1);

            Console.WriteLine(g2.Details);
        }
    }
}

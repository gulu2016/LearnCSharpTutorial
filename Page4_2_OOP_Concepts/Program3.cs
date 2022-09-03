// C# Program to illustrate calling
// a Private constructor
using System;
namespace privateConstructorExample
{

    public class Geeks
    {

        // declare private Constructor
        //p4_2-s3-1 私有构造器使用private修饰
        private Geeks()
        {
        }

        // declare static variable field
        //p4_2-s3-2 确保私有构造器的类中只有静态的属性或方法
        public static int count_geeks;

        // declare static method
        public static int geeks_Count()
        {
            return ++count_geeks;
        }

        // Main Method
        public static void Main3()
        {

            // If you uncomment the following
            // statement, it will generate
            // an error because the constructor
            // is unaccessible:
            // Geeks s = new Geeks(); // Error

            //p4_2-s3-3 使用带有私有构造器的类的时候，只调用静态的属性或方法
            Geeks.count_geeks = 99;

            // Accessing without any
            // instance of the class
            Geeks.geeks_Count();

            Console.WriteLine(Geeks.count_geeks);

            // Accessing without any
            // instance of the class
            Geeks.geeks_Count();

            Console.WriteLine(Geeks.count_geeks);
        }
    }
}

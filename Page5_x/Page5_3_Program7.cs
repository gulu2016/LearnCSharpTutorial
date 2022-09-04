// C# program to illustrate params
using System;
namespace Examples
{

    class Geeks7
    {

        // function containing params parameters
        //p5_3_s7-1 如果使用params类型参数，会将所有参数都放在一个数组中
        //p5_3_s7-2 params类型的参数适合参数个数不确定的场景
        ///p5_3_s7-3 如果使用了params的参数，那么只能有params类型的参数
        public static int mulval(params int[] num)
        {
            int res = 1;

            // foreach loop
            foreach (int j in num)
            {
                res *= j;
            }
            return res;
        }

        static void Main7(string[] args)
        {

            // Calling mulval method
            ///p5_3_s7-4 在使用的时候，可以传入很多个参数
            int x = mulval(20, 49, 56, 69, 78);

            // show result
            Console.WriteLine(x);
        }
    }
}

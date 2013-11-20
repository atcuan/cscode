using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp16_Const
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 10;
            const double PI = 3.1415;       //声明一个常量
            double l = 2 * PI * r;
            double s = PI * r * r;
            Console.WriteLine("周长{0}面积{1}",l,s);
            Console.ReadKey();
        }
    }
}

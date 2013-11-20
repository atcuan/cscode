using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3   //求圆周长
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi=3.1415926, cir;
            Console.WriteLine("请输入圆的半径:");
            string s1 = Console.ReadLine();
            double r = Convert.ToDouble(s1);
            cir = 2*pi*r;
            Console.WriteLine("圆的周长是：{0}",cir);
            Console.ReadKey();
        }
    }
}

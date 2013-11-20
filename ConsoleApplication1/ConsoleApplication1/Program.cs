using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //Console.WriteLine(str);
            //Console.ReadKey();

            Console.WriteLine("请输入第一个数字");
            string s1 = Console.ReadLine();//不能把 s1声明为int类型
            int i = Convert.ToInt32(s1);   //Convert.ToInt32将字符串转换为整形
            Console.WriteLine("请输入第二个数字");
            string s2 = Console.ReadLine();
            int j = Convert.ToInt32(s2);
            Console.WriteLine("{0}+{1}={2}", i, j, i + j);
            Console.ReadKey();

        }
    }
}


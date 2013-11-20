using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp9_Refout
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int age = 20;
            //IncAge(age);
            //IncAge(ref age);
            IncAge(out age);
            Console.WriteLine(age);
             */

            /*
            string str = Console.ReadLine();
            int i;
            if (int.TryParse(str, out i))
            {
                Console.WriteLine("转换成功{0}", i);
            }
            else 
            {
                Console.WriteLine("数据错误");
            }
             */

            int i = 10, j = 20;
            Swap(ref i,ref j);
            Console.WriteLine("i={0},j={1}", i, j);
            Console.ReadKey();
        }

        /* 
        static void IncAge(int age)//复制了一份，IncAge内部改变的是副本
        { 
            age++;
        }   
         */

        /*
        static void IncAge(ref int age)
        {
            age++; 
        }
         */

        /*
        static void IncAge(out int age)     //out 内部必须赋初值，一般用于函数有多个返回值的情况 
        {
            age=25;
        }
         */


        static void Swap(ref int i, ref int j)
        {
            int t = i;
            i = j;
            j = t;
        }




    }
}

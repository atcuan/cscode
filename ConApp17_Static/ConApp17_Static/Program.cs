using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp17_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.TotalCount = 30;     //全局变量，不用new就可以使用
            Console.WriteLine(Person.TotalCount);
            DoIt();
            Dog d1 = new Dog();
            d1.Call();
            Person.Speak();
            Person p1 = new Person();
            p1.SayHello();
            Console.ReadKey();
        }

        public static void DoIt()
        {
            Console.WriteLine("xixixixi");
            Console.WriteLine("使用全局变量:{0}",Person.TotalCount);
        }
    }

    public class Person
    {
        public static int TotalCount;
        public int Age;
        public static void Speak()
        {
            Console.WriteLine("已用时间{0}",TotalCount);
            //在static成员中不能直接调用非static成员
            //Console.WriteLine("已用时间{0}我的年龄是{1}", TotalCount,Age);
        }

        public void SayHello()
        {
            //在非static成员中可以直接调用static成员
            Console.WriteLine("我的年龄是{0}，我共用时间是{1}",Age,TotalCount);
        }
    }

    public class Dog
    {
        public void Call()
        {
            Console.WriteLine("汪汪{0}",Person.TotalCount);
        }
    }
}

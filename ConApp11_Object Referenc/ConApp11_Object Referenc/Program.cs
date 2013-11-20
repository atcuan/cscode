using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp11_Object_Referenc
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = i;
            i++;
            Console.WriteLine(j);
            /*int datetime bool char等类型都属于值类型，赋值时是传递的拷贝
             普通的对象则是引用类型，赋值时候是传递的引用*/
            Person p1 = new Person(10);
            Person p2 = p1;
            p1.Age++;
            Console.WriteLine(p2.Age);
            Console.ReadKey();
        }
    }

    class Person
    {
        public int Age { set; get; }
        public Person(int age)
        {
            this.Age = age;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Alex");
            Person p3 = new Person("Jack",20);

            Console.WriteLine("姓名{0},年龄{1}",p1.Name,p1.Age);
            Console.WriteLine("姓名{0},年龄{1}",p2.Name,p2.Age);
            Console.WriteLine("姓名{0},年龄{1}", p3.Name, p3.Age);

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { set; get; }
        public int Age { get; set; }
        //构造函数,亦可以重载
        public Person() 
        {
            Name = "未命名";
            Age = 0;
        }
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }  
    }
}

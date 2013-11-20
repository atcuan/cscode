using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp13_constructor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Alex");
            Person p3 = new Person("Tom",20);
            Person p4 = new Person("Miki", 20,181);
            Console.WriteLine("姓名{0}，年龄{1}，身高{2}",p1.Name,p1.Age,p1.Height);
            Console.WriteLine("姓名{0}，年龄{1}，身高{2}", p2.Name, p2.Age, p2.Height);
            Console.WriteLine("姓名{0}，年龄{1}，身高{2}", p3.Name, p3.Age, p3.Height);
            Console.WriteLine("姓名{0}，年龄{1}，身高{2}", p4.Name, p4.Age, p4.Height);

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public Person()
        {
            Name = "未命名";
            Age = 0;
    
         }

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, int height)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
        }
    }
}

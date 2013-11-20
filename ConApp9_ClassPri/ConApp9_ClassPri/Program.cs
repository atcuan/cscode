using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp9_ClassPri
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Alex";
            p1.Age = 22;
            p1.Height = 181;
            p1.Weight = 65;
            p1.Speak();
            Console.ReadKey();
        }
    }

    class Person
    {
        public int Age;
        public int Height;
        public int Weight;
        public string Name;

        public void Speak()
        {
            Console.WriteLine("大家好，我是新来的。还望多多关照！");
            Console.WriteLine("我的名字叫{0}，我的年龄是{1}，我的身高是{2}cm，我的体重是{3}kg",this.Name,this.Age,this.Height,this.Weight);
        }
    }
}

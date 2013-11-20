using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp10_OPPChatRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot r1 = new Robot();
            r1.Name = "小二";
            r1.Eat(5);
            r1.SayHello();
            while(true)
            {
                string str = Console.ReadLine();
                r1.Speak(str);
            }
            Console.ReadKey();
        }
    }

    class Robot 
    {
        public string Name { get; set; }
        private int FullLevel { get; set; }

        public void SayHello()
        {
            Console.WriteLine("我叫：{0}",Name);
        }

        public void Eat(int foodCount)
        {
            if (FullLevel > 100)
            {
                return;
            }
            FullLevel = FullLevel + foodCount;
        }

        public void Speak(string str)
        {
            if (FullLevel <= 0)
            {
                Console.WriteLine("饿死了，不说了！");
                return;
            }
            if (str.Contains("姓名") | str.Contains("名字"))
            {
                this.SayHello();    //类的方法调用的另外一个方法
            }
            else if (str.Contains("女朋友"))
            {
                Console.WriteLine("年龄小不考虑！");
            }
            else
            {
                Console.WriteLine("听不懂！");
            }
            FullLevel--;
        }
    }
}

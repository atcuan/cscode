using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp8_ChatRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,I am robot!");
            while (true)
            {
                string str = Console.ReadLine();
                if (str.Contains("天气"))
                {
                     //string city = str.Substring(2);
                    Console.WriteLine("北京的天气是晴朗");
                }
                else if (str.Contains("88") || str.Contains("拜拜") || str.Contains("再见") || str.Contains("bye"))
                {
                    Console.WriteLine("I am leaving...");
                    return;
                }
               
            }
            Console.ReadKey();
        }
    }
}

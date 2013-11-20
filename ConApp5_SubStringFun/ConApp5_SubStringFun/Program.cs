using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp5_SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string s = "http://www.google.com.hk";
            string domain = s.Substring(7);//从指定序号开始一直到最后的子字符串
            string s2 = s.Substring(7,14);
            Console.Write("{0}\n{1}",domain,s2);
            Console.ReadKey();
            */

            /*
            string s3 = "you son of bitch,kiss my ass!";
            if(s3.Contains("bitch") || s3.Contains("ass") )                 //Contains
            {
                Console.WriteLine("Kid,please speak like a gentleman!");
                Console.ReadKey();
            }*/

            /*
            string s4 = "http://www.baidu.com";
            if (s4.StartsWith("http://") || s4.StartsWith("https:''"))      //StartsWith   EndWith
            {
                Console.WriteLine("Yep,your url is not legal!");
            }
            else 
            {
                Console.WriteLine("Nope,it is a right url!");
            }
            Console.ReadKey();*/

            string s5 = "您好，我是川哥";
            //int i = s5.IndexOf("我是");       //返回子字符串的第一个字符第一次出现的位置
            int i = s5.IndexOf("你是");         //如果不存在则返回-1
            Console.WriteLine(i);
            Console.ReadKey();

        }
    }
}
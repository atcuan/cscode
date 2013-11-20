using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp6_StrExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*倒序输出输入的字符串*/
            /*
            Console.WriteLine("Pleas input a string:");
            string s = Console.ReadLine();
            for (int i = s.Length-1; i>=0; i--)
            {
                Console.Write(s[i]);
            }
            Console.ReadKey();
            */

            //输入一句英文，将其单词倒序输出
            /*
            Console.WriteLine("Please enter a sentence:");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            for (int i = words.Length - 1; i > 0; i--)
            {
                Console.Write(words[i]+" ");
            }
            Console.Write(words[0]);
                Console.ReadKey();
             */

            //从Email中提取用户名和域名
            /*
            Console.WriteLine("Please enter a email address:");
            string email = Console.ReadLine();
            int atIndex = email.IndexOf('@');
            string username = email.Substring(0,atIndex);
            string domain = email.Substring(atIndex+1);
            Console.WriteLine("username is {0}; doamin is {1}",username,domain);
            Console.ReadKey();
             */
            /*
            string[] lines = System.IO.File.ReadAllLines(@"D:\C#\ConApp6_StrExercise\1.txt",Encoding.Default);
            foreach(string line in lines)
            {
                string[] strs = line.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                string title = strs[0];
                string author = strs[1];
                title = title.Substring(0,Math.Min(17,title.Length));//控制显示的标题长度
                title = title + "....";
                Console.WriteLine("{0}{1}",title,author);
            }
            Console.ReadKey();
             */
 

        }
    }
}

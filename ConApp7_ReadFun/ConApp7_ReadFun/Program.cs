using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp7_ReadFun
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = GetConfigValue(@"D:\C#\ConApp7_ReadFun\config.ini", "port");
            Console.WriteLine(value);
            Console.ReadKey();
        }

        static string GetConfigValue(string fileName, string itenName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName,Encoding.Default);
            foreach(string line in lines)
            {
                string[] strs = line.Split('=');        //为什么改为":"会错误？
                string name = strs[0];
                string value = strs[1];
                if(name.Trim() == itenName)     
                {
                    return value.Trim();
                }
            }
            return "Error!";  
        }
    }
}

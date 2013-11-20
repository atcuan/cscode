

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please intput two numbers:");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", i, j, i + j);
            Console.ReadKey();
        }
    }
}
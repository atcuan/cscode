using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp18_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 2,5,8,4,7,6,5};
            int i = values[0];
            Person p1 = new Person();
            p1[1] = "小明";
            Console.WriteLine(p1[1]+p1[2]);
            Console.ReadKey();
        }
    }

    class Person
    {
        private string FirstName = "Alex";
        private string SecondName = "Show";
        public string this[int indexer]     //索引，可重载
        {
            set 
            {
                if (indexer == 1)
                {
                    FirstName = value;
                }
                else if (indexer == 2)
                {
                    SecondName = value;
                }
                else
                {
                    throw new Exception("数据错误！");
                }
            }

            get 
            {
                if (indexer == 1)
                {
                    return FirstName;
                }
                else if (indexer == 2)
                {
                    return SecondName;
                }
                else
                {
                    throw new Exception("数据错误！");
                }
            }
        }
    }
}

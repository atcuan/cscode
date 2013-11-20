using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp15_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Before Convert");
                int i = Convert.ToInt32("abd");
                Console.WriteLine("After Convert");
            }
            catch(Exception ex)
            {
                Console.WriteLine("数据错误" + ex.Message + "异常堆栈"+ex.StackTrace);
            }
            Console.WriteLine("Before ReadKey");

            try
            {
                //string desc = GetAgeDesc(300);
                string desc1 = GetAgeDesc(-12);
            }
            catch (Exception ex)
            {
                Console.WriteLine("数据错误"+ex.Message);
            }
            Console.ReadKey();
        }

        static string GetAgeDesc(int age)
        {
            if (age >= 0 && age <= 3)
            {
                return "婴幼儿";
            }
            else if(age >3 && age<= 16)
            {
                return "青少年";
            }
            else if (age > 16 && age < 125)
            {
                return "成年人";
            }
            else if (age < 0)
            {
                throw new Exception("You are kidding!");
            }
            else
            {
                throw new Exception("想活这么久累不累？");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConApp14_Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            Chinese c1 = new Chinese();
            c1.Name = "李小龙";
            c1.SayHello();
            c1.HuKou = "BeiJing";
            Console.WriteLine(c1.HuKou);
            c1.KungFu();

            American a1 = new American();
            a1.Name = "Alex";
            a1.SayHello();
            a1.colour = "black";
            Console.WriteLine(a1.colour);
            a1.Language();
            Console.ReadKey();
        }
    }

    class  Person
    {
        public string Name{set;get;}
        public int Age{get;set;}
        public int Height { set; get; }
        public void SayHello()
        {
            Console.WriteLine("{0}",this.Name);
        }
    }

    class Chinese : Person
    {
        public string HuKou { set; get; }
        public void KungFu()
        {
            Console.WriteLine("Let me show you!");
        }
    }

    class American : Person
    {
        public string colour { set; get; }

        public void Language()
        {
            Console.WriteLine("We speak En");
        }
    }
}

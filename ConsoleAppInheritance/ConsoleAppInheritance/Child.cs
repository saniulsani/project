using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    internal abstract class Child : Parent
    {
        internal Child() : this(10)//base("c#")
        {
            Console.WriteLine("Child D");
        }

        internal Child(int a) : base(a)
        {
            Console.WriteLine($"Child ND-I {a}");
        }

        internal Child(string a) : this()//base(2002)
        {
            Console.WriteLine($"Child ND-S {a}");
        }

        internal void MethodA()
        {
            Console.WriteLine("Child MethodA");
        }

        internal override sealed void MethodB()
        {
            Console.WriteLine("Child MethodB");
        }

        internal new virtual void MethodC()
        {
            Console.WriteLine("Child MethodC");
        }

        internal override void MethodD()
        {
            Console.WriteLine("Child MethodD");
        }
    }
}

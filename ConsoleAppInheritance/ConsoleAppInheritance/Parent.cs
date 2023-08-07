using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    internal abstract class Parent
    {
        internal Parent() : this("Welcome")
        {
            Console.WriteLine("Parent D");
        }

        internal Parent(int a) : this()
        {
            Console.WriteLine($"Parent ND-I {a}");
        }

        internal Parent(string a)
        {
            Console.WriteLine($"Parent ND-S {a}");
        }

        internal void MethodA()
        {
            Console.WriteLine("Parent MethodA");
        }

        internal virtual void MethodB()
        {
            Console.WriteLine("Parent MethodB");
        }

        internal virtual void MethodC()
        {
            Console.WriteLine("Parent MethodC");
        }

        internal abstract void MethodD();

        internal abstract void MethodE(int y);
    }
}

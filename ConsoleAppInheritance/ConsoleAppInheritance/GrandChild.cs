using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    internal class GrandChild : Child
    {
        //internal override void MethodB()
        //{
        //    Console.WriteLine("GrandChild MethodB");
        //}

        internal override void MethodC()
        {
            Console.WriteLine("GrandChild MethodC");
        }

        internal override void MethodD()
        {
            Console.WriteLine("GrandChild MethodD");
        }

        internal override void MethodE(int y)
        {
            Console.WriteLine("GrandChild MethodE");
        }
    }
}

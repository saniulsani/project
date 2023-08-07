using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parent p1 = new Parent();
            //Parent p2 = new Parent(35);
            //Child c1 = new Child();
            //Child c2 = new Child(10);
            //Child c3 = new Child("Hello");

            //Parent pp = new Child();
            //Parent pp1 = new GrandChild();

            //Console.WriteLine();

            //p1.MethodA();
            //c1.MethodA();
            //p1.MethodB();
            //c1.MethodB();
            //pp.MethodA();
            //pp.MethodB();
            //pp1.MethodB();
            //pp.MethodC();

            //Parent[] p = new Parent[3];
            //p[0] = new Parent();
            //p[1] = new Child();

            //Person p = new Person(100, "Bruce", "B+", new AddressFormat(34, 2, 1289, "Khulna"));
            //Student s = new Student(200, "Clerk", "AB+", new AddressFormat(72, 21, 9890, "Sylhet"), 3.42);
            //Employee e = new Employee(300, "Diana", "A+", new AddressFormat(98, 11, 6754, "Bogura"), 23000);
            //Person[] people = new Person[3];
            //people[0] = new Student("Bruce", "B+", new AddressFormat(34, 2, 1289, "Khulna"), 3.26);
            //people[1] = new Student("Clerk", "AB+", new AddressFormat(72, 21, 9890, "Sylhet"), 3.42);
            //people[2] = new Employee("Diana", "A+", new AddressFormat(98, 11, 6754, "Bogura"), 23000);

            //foreach (Person p in people)
            //    p.PrintInfo();

            //int z;
            //XYZOrganization li = new XYZOrganization();
            //XYZOrganization.AddPerson(new Student("Bruce", "B+", new AddressFormat(34, 2, 1289, "Khulna"), 3.26));
            //XYZOrganization.AddPerson(new Student("Clerk", "AB+", new AddressFormat(72, 21, 9890, "Sylhet"), 3.42));
            //XYZOrganization.AddPerson(new Employee("Diana", "A+", new AddressFormat(98, 11, 6754, "Bogura"), 23000));
            //XYZOrganization.AddPerson(new Employee("Arthur", "O+", new AddressFormat(24, 76, 9821, "Cumilla"), 18000));
            //XYZOrganization.ShowAll();
            //XYZOrganization.Search("P-2-S", out z);
            //XYZOrganization.RemovePerson("P-2-S");

            //p.PrintInfo();
            //s.PrintInfo();
            //e.PrintInfo();

            //Object o1 = 12;
            //Object o2 = 45.6;
            //Object o3 = "Hello";
            //Object o4 = new Sample();

            //Console.WriteLine(o1.GetType());
            //Console.WriteLine(o2.GetType());
            //Console.WriteLine(o3.GetType());
            //Console.WriteLine(o4.GetType());

            //var a = 9;
            //var b = 12.4;
            //var c = "TEXT";
            //var d = new Sample();

            //Console.WriteLine(a.GetType());
            //Console.WriteLine(b.GetType());
            //Console.WriteLine(c.GetType());
            //Console.WriteLine(d.GetType());

            //dynamic p = 34;
            //dynamic q = new Sample();
            //q.Test();

            //Nullable<int> r = null;
            //int? k = null;
            //int w = k ?? 30;

            string str1 = "C# Programming";
            string str2 = "C# Programming";
            string str3 = "This is a test sentence for us";

            String str4 = "C# Programming";
            if (str1 == str4)
                Console.WriteLine("T");
            else
                Console.WriteLine("F");

            Console.WriteLine(str1.Equals(str4));

        }
    }
}

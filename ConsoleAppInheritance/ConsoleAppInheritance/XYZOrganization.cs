using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    internal static class XYZOrganization
    {
        private static Person[] personList = new Person[40];
        private static int count = 0;

        internal static void AddPerson(Person p)
        {
            personList[count] = p;
            count++;
        }

        internal static void ShowAll()
        {
            int index = 0;
            while(index < count)
            {
                if(personList[index] != null)
                    personList[index].PrintInfo();
                index++;
            }
        }

        internal static bool Search(string key, out int info)
        {
            bool found = false;
            int index = 0;
            while (index < count)
            {
                if(key == personList[index].Id)
                {
                    found = true;
                    info = index;
                    Console.WriteLine("Data Found");
                    personList[index].PrintInfo();
                    //break;
                    return found;
                }
                index++;
            }

            info = -1;

            if (!found)
                Console.WriteLine("Data Not Found");
            return found;
        }

        internal static void RemovePerson(string key)
        {
            int indexValue;
            bool status = Search(key, out indexValue);

            if(status)
            {
                personList[indexValue] = null;
                Console.WriteLine("Data Removed\n");
                ShowAll();
            }
        }
    }
}

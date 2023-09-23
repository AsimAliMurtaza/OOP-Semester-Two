using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class DL
    {
        public static List<Person> list = new List<Person>();

        public static void addUser(Person person)
        {
            list.Add(person);
        }

        public static List<Person> getList()
        {
            return list;
        }
    }
}

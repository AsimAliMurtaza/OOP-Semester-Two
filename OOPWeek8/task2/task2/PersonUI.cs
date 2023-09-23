using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class PersonUI
    {
        public static void showInfo(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.toString());
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ToDoApp.Entity
{
    public class PersonData
    {
        private static List<Person> person = new List<Person>();
        public static List<Person> defaultPersons()
        {
            person.Add(new Person("Hüseyin", "ÖZTÜRK", 1));
            person.Add(new Person("Dilber", "AYDIN", 2));
            return person;
        }


    }
}

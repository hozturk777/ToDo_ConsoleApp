using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Entity
{
    public class Person
    {
        private int id{ get; set; }
        private string name { get; set; }
        private string surname { get; set; }

        public Person(string Name, string Surname, int ID)
        {
            name = Name;
            surname = Surname;
            id = ID;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int ID { get => id; set => id = value; }
        

    }
}

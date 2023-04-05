using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Enum;

namespace ToDoApp.Entity
{
    public class Cart 
    {
        private string title { get; set; }
        private string contents { get; set; }
        private Person person { get; set; }
        private SizeEnum size { get; set; }
        private LineEnum line { get; set; }

        public string Title { get => title; set => title = value; }
        public string Contents { get => contents; set => contents = value; }
        public Person Person { get => person; set => person = value; }
        public SizeEnum Size { get => size; set => size = value; }
        public LineEnum Line { get => line; set => line = value; }

        public Cart(string Title, string Contents, Person Person, int Size, LineEnum Line)
        {
            title = Title;
            contents = Contents;
            person = Person;
            size = (SizeEnum)Size;
            line = Line;
        }

        

 

   

    }
}

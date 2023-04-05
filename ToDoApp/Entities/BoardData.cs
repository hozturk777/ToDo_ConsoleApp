using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entity;

namespace ToDoApp.EntityLayer
{
    public class BoardData
    {
        public static List<Cart> cart = new List<Cart>();
        public static List<Person> person = new List<Person>();

   
        public static List<Cart> Carts()
        {
            person.AddRange(PersonData.defaultPersons());

            cart.Add(new Cart("Başlık 1", "İçerik 1", person.Where(x => x.ID == 1).FirstOrDefault(), 4, Enum.LineEnum.ToDoLine));
            cart.Add(new Cart("Başlık 2", "İçerik 2", person.Where(x => x.ID == 2).FirstOrDefault(), 1, Enum.LineEnum.InProgressLine));
            cart.Add(new Cart("Başlık 3", "İçerik 3", person.Where(x => x.ID == 2).FirstOrDefault(), 2, Enum.LineEnum.InProgressLine));
            cart.Add(new Cart("Başlık 4", "İçerik 4", person.Where(x => x.ID == 1).FirstOrDefault(), 3, Enum.LineEnum.DoneLine));
            return cart;
        }
        static BoardData()
        {
            BoardData.Carts();
        }

    }
}

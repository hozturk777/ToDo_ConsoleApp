using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entity;
using ToDoApp.EntityLayer;
using ToDoApp.Enum;

namespace ToDoApp.BusinessLayer
{
    public class CartListManager
    {
        //static CartListManager()
        //{
        //    BoardData.Carts();
        //}
        public static void ToDoList()
        {
            Console.WriteLine(" \tTODO Line\r\n ************************");
            foreach (var cart in BoardData.cart)
            {
                if (cart.Line == LineEnum.ToDoLine)
                {
                    Console.WriteLine($" Başlık      :{cart.Title}");
                    Console.WriteLine($" İçerik      :{cart.Contents}");
                    Console.WriteLine($" Atanan Kişi :{cart.Person.Name} {cart.Person.Surname}");
                    Console.WriteLine($" Büyüklük    :{cart.Size}");
                    Console.WriteLine(" \n --- \n");
                }
            }
            if (BoardData.cart.FirstOrDefault(x => x.Line == LineEnum.ToDoLine) is null)
            {
                Console.WriteLine("Boş");
            }
        }
        public static void InProgressList()
        {
            Console.WriteLine("     IN PROGRESS Line\r\n ************************");
            foreach (var cart in BoardData.cart)
            {
                if (cart.Line == LineEnum.InProgressLine)
                {
                    Console.WriteLine($" Başlık      :{cart.Title}");
                    Console.WriteLine($" İçerik      :{cart.Contents}");
                    Console.WriteLine($" Atanan Kişi :{cart.Person.Name} {cart.Person.Surname}");
                    Console.WriteLine($" Büyüklük    :{cart.Size}");
                    Console.WriteLine(" \n --- \n");
                }
            }
            if (BoardData.cart.FirstOrDefault(x => x.Line == LineEnum.InProgressLine) is null)
            {
                Console.WriteLine("Boş");
            }
        }
        public static void DoneList()
        {
            Console.WriteLine(" \tDONE Line\r\n ************************");
            foreach (var cart in BoardData.cart)
            {
                if (cart.Line == LineEnum.DoneLine)
                {
                    Console.WriteLine($" Başlık      :{cart.Title}");
                    Console.WriteLine($" İçerik      :{cart.Contents}");
                    Console.WriteLine($" Atanan Kişi :{cart.Person.Name} {cart.Person.Surname}");
                    Console.WriteLine($" Büyüklük    :{cart.Size}");
                    Console.WriteLine(" \n --- \n");
                }
            }
            if (BoardData.cart.FirstOrDefault(x => x.Line == LineEnum.DoneLine) is null)
            {
                Console.WriteLine("Boş");
            }

            Menu.Choice();
        }
    }
}

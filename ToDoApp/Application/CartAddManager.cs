using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.BusinessLayer;
using ToDoApp.Entity;
using ToDoApp.EntityLayer;

namespace ToDoApp.Application
{
    public class CartAddManager
    {
        public static void CartAdd()
        {
            Console.WriteLine($"Başlık Giriniz\t\t:");
            string title = Console.ReadLine();


            Console.WriteLine($"İçerik Giriniz\t\t:");
            string contents = Console.ReadLine();


            Console.WriteLine($"Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
            int size = int.Parse(Console.ReadLine());


            Console.WriteLine($"Kişinin id numarasını giriniz\t\t:");
            int prsn = int.Parse(Console.ReadLine());
            bool successful = false;

            foreach (var item in BoardData.person)
            {
                if (item.ID == prsn)
                {
                    Cart cart1 = new Cart(title, contents, item, size, Enum.LineEnum.ToDoLine);
                    BoardData.cart.Add(cart1);
                    successful = true;
                }
            }
            if (successful == false)
            {
                Console.WriteLine("Hatalı giriş yaptınız işlem iptal edilmiştir!!");
            }
          

            Menu.Choice();

        }

    }
}

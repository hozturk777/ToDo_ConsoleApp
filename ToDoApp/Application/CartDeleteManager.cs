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
    public class CartDeleteManager
    {

        public static void CartDelete()
        {

            Console.Write(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\r\n Lütfen kart başlığını yazınız:  ");
            string cartTitle = Console.ReadLine();
            bool successful = false;
            int errorChoice;

            foreach (var cart in BoardData.cart.ToList())
            {
                if (cart.Title.ToLower() == cartTitle.ToLower())
                {
                    BoardData.cart.Remove(cart);
                    successful = true;
                }
            }
            if (successful == false)
            {
                Console.WriteLine("\r\n Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Silmeyi sonlandırmak için : (1)\r\n * Yeniden denemek için : (2)");
                errorChoice = int.Parse(Console.ReadLine());
                if (errorChoice == 2)
                {
                    CartDeleteManager.CartDelete();
                }
                else
                {
                    Console.WriteLine("İşlem İptal Edilmiştir");
                }
            }
            Menu.Choice();
        }
    }
}

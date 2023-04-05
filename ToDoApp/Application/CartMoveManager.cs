using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.BusinessLayer;
using ToDoApp.EntityLayer;

namespace ToDoApp.Application
{
    public class CartMoveManager
    {
        public static void CartMove()
        {
            string cartName;
            int choice;
            int errorChoice;
            bool successful = false;
            Console.WriteLine("\r\n Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.  ");
            foreach (var cartInfo in BoardData.cart)
            {
                Console.WriteLine($"Kart İsmi : {cartInfo.Title}\tKart Line : {cartInfo.Line}");
            }
            cartName = Console.ReadLine();

            foreach (var cart in BoardData.cart)
            {
                if (cart.Title.ToLower() == cartName.ToLower())
                {
                    Console.WriteLine("\r\n Bulunan Kart Bilgileri:\r\n **************************************");
                    Console.WriteLine($" Başlık      : {cart.Title}");
                    Console.WriteLine($" İçerik      : {cart.Contents}");
                    Console.WriteLine($" Atanan Kişi : {cart.Person.Name} {cart.Person.Surname}");
                    Console.WriteLine($" Büyüklük    : {cart.Size}");
                    Console.WriteLine($" Line        : {cart.Line}");

                    Console.WriteLine(" Lütfen taşımak istediğiniz Line'ı seçiniz: \r\n (1) TODO\r\n (2) IN PROGRESS\r\n (3) DONE");
                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        cart.Line = Enum.LineEnum.ToDoLine;
                    }
                    else if (choice == 2)
                    {
                        cart.Line = Enum.LineEnum.InProgressLine;
                    }
                    else if (choice == 3)
                    {
                        cart.Line = Enum.LineEnum.DoneLine;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz işlem kart line değişimi yapılamadı!");
                    }
                    successful = true;
                }
            }
            if (successful == true)
            {
                Console.WriteLine("Kart line değişimi sonrası :");
                foreach (var cartInfo in BoardData.cart)
                {
                    Console.WriteLine($"Kart İsmi : {cartInfo.Title}\tKart Line : {cartInfo.Line}");
                }
            }
            if (successful == false)
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\r\n * İşlemi sonlandırmak için : (1)\r\n * Yeniden denemek için : (2)");
                errorChoice = int.Parse(Console.ReadLine());
                if (errorChoice == 2)
                {
                    CartMoveManager.CartMove();
                }
                else
                {
                    Console.WriteLine("İşlem sonlandırılıyor!");
                }
            }
            Menu.Choice();
        }
    }
}

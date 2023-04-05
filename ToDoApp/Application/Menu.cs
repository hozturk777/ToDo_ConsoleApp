using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application;
using ToDoApp.Entity;
using ToDoApp.EntityLayer;

namespace ToDoApp.BusinessLayer
{
    public class Menu
    {

        public static void Choice()
        {
            Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :) \r\n *******************************************");
            Console.WriteLine("  (1) Board Listelemek\r\n  (2) Board'a Kart Eklemek\r\n  (3) Board'dan Kart Silmek\r\n  (4) Kart Taşımak\r\n  (5) Çıkış");
            int chc = int.Parse(Console.ReadLine());

            switch (chc)
            {
                case 1:
                    BoardList();
                    break;
                case 2:
                    BoardCartAdd();
                    break;
                case 3:
                    BoardCartDelete();
                    break;
                case 4:
                    CartMove();
                    break;
                default:
                    Console.WriteLine("Uygulama Kapatılıyor");
                    break;
            }


        }
        public static void BoardList()
        {

            
            CartListManager.ToDoList();
            CartListManager.InProgressList();
            CartListManager.DoneList();


        }
        public static void BoardCartAdd()
        {
            CartAddManager.CartAdd();
        }
        public static void BoardCartDelete()
        {
            CartDeleteManager.CartDelete();
        }
        public static void CartMove()
        {
            CartMoveManager.CartMove();
        }
    }
}

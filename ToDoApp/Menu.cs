using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class Menu
    {
        public static void MenuUI()
        {
            CardManager cardManager = new CardManager();

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz  :");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    cardManager.ListAll();
                    break;
                case 2:
                    cardManager.Add();
                    break;
                case 3:
                    cardManager.Delete();
                    break;
                case 4:
                    cardManager.Transfer();
                    break;
                default:
                    Console.WriteLine("Hatali secim yaptiniz!");
                    Menu.MenuUI();
                    break;
            }
        }
    }
}

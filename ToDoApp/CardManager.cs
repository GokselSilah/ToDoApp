using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoApp
{
    public class CardManager
    {
        public static List<Card> cards = new List<Card>()
        {
            new Card() { Header = "Todo List", Description = "A todo List Console App", Employee = EmployeeManager.GetById(1) , Size = Variables.Size.M.ToString(), BoardId =3  },
            new Card() { Header = "Phone List", Description = "A Phone List Console App", Employee = EmployeeManager.GetById(2) , Size = Variables.Size.S.ToString(), BoardId =1  },
            new Card() { Header = "Online Satış Platformu", Description = "Online Satış Platformu", Employee = EmployeeManager.GetById(3) , Size = Variables.Size.XL.ToString(), BoardId =2  },
            new Card() { Header = "MakeUp", Description = "Makyaj simülasyonu", Employee = EmployeeManager.GetById(4) , Size = Variables.Size.L.ToString(), BoardId =1  },
            new Card() { Header = "Farming Simulator", Description = "Çiftçilik Hakkında Herşey", Employee = EmployeeManager.GetById(6) , Size = Variables.Size.XL.ToString(), BoardId =2  }

        };

        public void Add()
        {
            Console.WriteLine("Başlık Giriniz               :");
            var cardHeader = Console.ReadLine();
            Console.WriteLine("Açıklama Giriniz             :");
            var cardDescription = Console.ReadLine();
            Console.WriteLine("Çalışan Seçiniz              : Göksel(1) - Cemre(2) - Ayşegül(3) - Gözde(4) - Merve(5) - Can(6) - Umut(7) - Özge(8)");
            int cardEmployee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Board Tipi Giriniz           : TODO Line(1) - IN PROGRESS Line(2) - DONE Line(3)");
            var cardBoardId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Büyüklük Giriniz             : XS(1) - S(2) - M(3) - L(4) - XL(5)");
            int cardSizeId = Convert.ToInt32(Console.ReadLine());
            string cardSize = "";

            var result = cards.Find(c => c.Description == cardDescription);


            switch (cardSizeId)
            {
                case 1: cardSize = Variables.Size.XS.ToString(); break;
                case 2: cardSize = Variables.Size.S.ToString(); break;
                case 3: cardSize = Variables.Size.M.ToString(); break;
                case 4: cardSize = Variables.Size.L.ToString(); break;
                case 5: cardSize = Variables.Size.XL.ToString(); break;
                default: Console.WriteLine("YanlışSeçim Yaptınız."); break;
            }




            if (cards.Contains(result))
            {
                Console.WriteLine("ToDo zaten mevcut.");
                Menu.MenuUI();

            }
            else
            {

                cards.Add(new Card() { Header = cardHeader, Description = cardDescription, BoardId = cardBoardId, Size = cardSize, Employee = EmployeeManager.GetById(cardEmployee) });
                Menu.MenuUI();

            }
        }

        public void List(List<Card> cards, int id)
        {
            foreach (var card in cards)
            {
                if (id == card.BoardId)
                {
                    Console.WriteLine($"Başlık      : {card.Header}");
                    Console.WriteLine($"Açıklama    : {card.Description}");
                    Console.WriteLine($"Atanan Kişi : {card.Employee}");
                    Console.WriteLine($"Büyüklük    : {card.Size}");
                    Console.WriteLine("------");
                }
            }

        }

        public void ListAll()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("********************************");
            List(cards, 1);

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("********************************");
            List(cards, 2);

            Console.WriteLine("DONE ");
            Console.WriteLine("********************************");
            List(cards, 3);

            Menu.MenuUI();
        }

        public void Delete()
        {
            Console.WriteLine("Silmek İstediğiniz Kartın Adını Giriniz :");
            var deleteCard = Console.ReadLine();

            var result = cards.SingleOrDefault(c => c.Header == deleteCard);

            cards.Remove(result);

            Menu.MenuUI();
        }

        public void Transfer()
        {
            Console.WriteLine("Değiştirmek İstediğiniz Kartın Adını Giriniz :");
            string inputHeader = Console.ReadLine();
            var card = cards.SingleOrDefault(c => c.Header == inputHeader);

            if (card == null)
            {
                Console.WriteLine($"İşlemi Sonlandırmak için (1)");
                Console.WriteLine($"Yeniden Denemek için (2)");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1: Menu.MenuUI(); break;
                    case 2: Transfer(); break;
                    default:
                        break;
                }
            }

            else
            {
                Console.WriteLine("Lütfen Taşımak İstediğiniz Line'ı Seçiniz :");
                Console.WriteLine("(1) TODO ");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");

                int select = Convert.ToInt32(Console.ReadLine());
                if (select == 1)
                {
                    card.BoardId = 1;
                    Menu.MenuUI();
                }
                else if (select == 2)
                {
                    card.BoardId = 2;
                    Menu.MenuUI();

                }
                else if (select == 3)
                {
                    card.BoardId = 3;
                    Menu.MenuUI();
                }
                else
                {
                    Console.WriteLine("Hatalı Bir Seçim Yaptınız");
                    Transfer();
                }

            }
        }
    }
}

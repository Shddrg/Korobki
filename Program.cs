using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace korobki
{
    public class Inventory
        {
            public bool empty;
            public int number;
            public string name;
        }
    internal class Program
    {
        void Breake()
        {
            Program program = new Program();
            Console.WriteLine("Нажмите Enter что бы продолжить");
            Console.ReadLine();
            Console.Clear();
            program.Menu();

        }
        void Play()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            Program program = new Program();
            BoxesItems boxesItems = new BoxesItems();
            Console.Clear();
            Random rnd = new Random();
            int r = rnd.Next(1, 100);
            if (r > 50 && r<=100)
            {
                boxesItems.usBox();
                a = 1;//картон
                b = 2;//скотч
                c = 3;//бумага
            }
            if (r > 25 && r <=50)
            {
                boxesItems.unusBox();
                a = 4;//оберточная бумага
                b = 5;//дерево
                c = 2;//скотч
            }
            if (r > 10 && r <=25)
            {
                boxesItems.rBox();
                a = 6;//металл
                b = 5;//дерево
                c = 4;//оберточная бумага
            }
            if (r > 2 && r <= 10)
            {
                boxesItems.eBox();
                a = 7;//серебро
                b = 6;//металл
                c = 8;//гвозди
            }
            if (r > 0 && r <= 2)
            {
                boxesItems.lBox();
                a = 9;//Золото
                b = 7;//серебро
                c = 10;//пенопалст
                
            }
            Console.WriteLine("Нажмите Enter что бы открыть коробку");
            Console.ReadLine();
            int i = new int();
            int count = 0;
            (i,count) = boxesItems.Open(a, b, c);
            switch (i)
            {
                case 1:
                    boxesItems.Karton(count);
                    break;
                case 2:
                    boxesItems.Scotch(count); break;
                case 3:
                    boxesItems.Bumaga(count); break;
                case 4:
                    boxesItems.Obertochnaya_Bumaga(count); break;
                case 5:
                    boxesItems.Derevo(count); break;
                case 6:
                    boxesItems.Metal(count); break;
                case 7:
                    boxesItems.Serebro(count); break;
                case 8:
                    boxesItems.Gvozdi(count); break;
                case 9:
                    boxesItems.Zoloto(count); break;
                case 10:
                    boxesItems.Penoplast(count); break;
            }
            program.Breake();
        }
        void Menu()
        {
            Program program = new Program();
            Console.WriteLine("1. Выбить коробку");
            Console.WriteLine("2. Инвентарь");
            Console.WriteLine("3. Выход");
            string s = Console.ReadLine();
            if (int.TryParse(s, out var i))
            {
                i = Convert.ToInt32(s);
            }
            switch (i)
            {
                case 1:
                    program.Play();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("В разработке");
                    program.Breake();
                    break;
                case 3:
                    
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Неверный ввод");
                    program.Breake();
                    break;
            }
        }
        static void Main()
        {
            Program program = new Program();
            program.Menu();
        }
    }
}

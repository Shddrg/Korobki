using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace korobki
{
    internal class BoxesItems
    {
        public (int,int) Open(int a, int b, int c)
        {
            int ans = 0;
            int count = 0;
            Random random = new Random();
            int rnd = random.Next(0, 90);
            if ((rnd >= 0 && rnd<10)||(rnd>=30 && rnd < 40)||(rnd >= 60 && rnd <70 ))//рандом 1 позиции
            {
                ans = a;
            }
            if ((rnd >= 10 && rnd < 20) || (rnd >= 40 && rnd < 50) || (rnd >= 70 && rnd < 80))//рандом 2 позиции
            {
                ans = b;
            }
            if ((rnd >= 20 && rnd < 30) || (rnd >= 50 && rnd < 60) || (rnd >= 80 && rnd < 90))//рандом 3 позиции
            {
                ans = c;
            }
            if (rnd >= 0 && rnd < 30)//рандом кол-ва (1-шт)
            {
                count = 1;
            }
            if (rnd >=30 && rnd <60)//рандом кол-ва (2-шт)
            {
                count = 2;
            }
            if (rnd >=60 && rnd <90)//рандом кол-ва (3-шт)
            {
                count = 3;
            }

            return (ans,count);
        }
        public void usBox()
        {
            Console.WriteLine("*---*");
            Console.WriteLine("| О |");
            Console.WriteLine("*---*");
        }
        public void unusBox()
        {
            Console.WriteLine("*---*");
            Console.WriteLine("| Н |");
            Console.WriteLine("*---*");

        }
        public void rBox()
        {
            Console.WriteLine("*---*");
            Console.WriteLine("| Р |");
            Console.WriteLine("*---*");
        }
        public void eBox()
        {
            Console.WriteLine("*---*");
            Console.WriteLine("| Э |");
            Console.WriteLine("*---*");
        }
        public void lBox()
        {
            Console.WriteLine("*---*");
            Console.WriteLine("| Л |");
            Console.WriteLine("*---*");
        }

        public void Karton(int count)
        {
            Console.WriteLine("Картон {0}-шт", count);
        }
        public void Scotch(int count)
        {
            Console.WriteLine("Скотч {0}-шт", count);
        }
        public void Bumaga(int count)
        {
            Console.WriteLine("Бумага {0}-шт", count);
        }
        public void Obertochnaya_Bumaga(int count)
        {
            Console.WriteLine("Оберточная бумага {0}-шт", count);
        }
        public void Derevo(int count)
        {
            Console.WriteLine("Дерево {0}-шт", count);
        }
        public void Metal(int count)
        {
            Console.WriteLine("Металл {0}-шт", count);
        }
        public void Serebro(int count)
        {
            Console.WriteLine("Серебро {0}-шт", count);
        }
        public void Gvozdi(int count)
        {
            Console.WriteLine("Гвозди {0}-шт", count);
        }
        public void Zoloto(int count)
        {
            Console.WriteLine("Золото {0}-шт", count);
        }
        public void Penoplast(int count)
        {
            Console.WriteLine("Пенопласт {0}-шт", count);
        }

    }
}

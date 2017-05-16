using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    class Szachy
    {
        static void Main(string[] args)
        {
            Szachownica szachownica = Szachownica.Szach;

            Figura Król = Ruch.inst(NazwaFigury.Król, 'C', 4, Kolory.White);
            Figura Wieża = Ruch.inst(NazwaFigury.Wieża, 'D', 7, Kolory.Black);
            Figura Hetman = Ruch.inst(NazwaFigury.Hetman, 'G', 3, Kolory.White);
            Figura Goniec = Ruch.inst(NazwaFigury.Goniec, 'G', 6, Kolory.Black);


            szachownica[Król, 'D', 5] = Król.ToString();
            szachownica[Wieża, 'G', 7] = Wieża.ToString();
            szachownica[Hetman, 'A', 2] = Hetman.ToString();
            szachownica[Goniec, 'B', 3] = Goniec.ToString();
            szachownica.PokazSzachownice();
            Console.WriteLine("Na szachownicy znajdują się " + szachownica.LiczbaFigur() + " figury.");

            Console.ReadKey();
        }
    }
    }

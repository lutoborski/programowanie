using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    public sealed class Szachownica
    {
        private static Szachownica szachownica = new Szachownica();

        public static Szachownica Szach
        {
            get
            {
                return szachownica;
            }
        }

        private const int WielkoscSzachownicy = 8;

        private string[,] plansza;

        public string[,] Plansza
        {
            get
            {
                return plansza;
            }
        }

        static Szachownica() { }

        private Szachownica()
        {
            plansza = new string[WielkoscSzachownicy, WielkoscSzachownicy];
        }

        public string this[Figura figura, char x, int y]
        {
            get
            {
                return Plansza[x - 65, y];
            }
            set
            {
                Plansza[x - 65, y] = value;
                figura.X = x;
                figura.Y = y;
            }
        }
        public void PokazSzachownice()
        {
            int limit = WielkoscSzachownicy;

            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    if (!string.IsNullOrEmpty(plansza[i, j]))
                    {
                        Console.WriteLine(plansza[i, j]);
                    }
                }
            }
        }
    }
        public static class ZliczanieFigur
        {
            public static int LiczbaFigur (this Szachownica szach)
            {
                string[,] array = szach.Plansza;
                int count = 0;
                foreach (var s in array)
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        count++;
                    }
                }

                return count;
            }
        }
    }
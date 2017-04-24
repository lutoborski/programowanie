using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    sealed class Szachownica
    {
        private string[,] plansza;
    
        public Szachownica()
        {
            plansza = new string[8, 8];
        }

        public string this[char x, int y]
        {
            get
            {
                return plansza[x - 65, y];
            }
            set
            {
                plansza[x - 65, y] = value;
            }
        }
            public void WyliczSzachownica()
        {
            int maks = (int)Math.Sqrt(plansza.Length);

            for (int i = 0; i < maks; i++)
            {
                for (int j = 0; j < maks; j++)
                {
                    if (!string.IsNullOrEmpty(plansza[i, j]))
                    {
                        Console.WriteLine(plansza[i, j]);
                    }
                }
            }
        }

    }
    }

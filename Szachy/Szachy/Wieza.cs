using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    class Wieza : Figura
    {
        public Wieza(char x, int y, Kolory kolor) : base(x, y, kolor)
        {
            nazwa = "Wieza";
        }

        public override bool MozeRuszyc(char x, int y)
        {
            int liczbaX = ConvertPosition(x);

            if (!base.MozeRuszyc(x, y))
            {
                return false;
            }

            int pozycjaX = liczbaX;
            int pozycjaY = y;

            int diffY = Math.Abs(y - pozycjaY);
            int diffX = Math.Abs(ConvertPosition(X) - pozycjaX);

            if (diffY == 0 && diffX != 0)
            {
                return true;
            }

            if (diffX == 0 && diffY != 0)
            {
                return true;
            }

                 return false;
        }
    }
}


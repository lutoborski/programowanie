using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    class Krol : Figura
    {
        public Krol(char x, int y, Kolory kolor) : base(x, y, kolor)
        {
            nazwa = "Król";
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

            int diffY = Math.Abs(Y - pozycjaY);
            int diffX = Math.Abs(ConvertPosition(X) - pozycjaX);

            if (diffX == 1 && diffY == 1)
            {
                return true;
            }

            if (diffY == 1 && diffX == 0)
            {
                return true;
            }

            if (diffX == 1 && diffY == 0)
            {
                return true;
            }
          
            return false;
        }
    }
}

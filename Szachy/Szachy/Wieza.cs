using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    class Wieza : Figura
    {
        public Wieza(object x, int y, int kolor) : base(x, y, kolor)
        {
            nazwa = "Wieza";
        }

        public override bool MozeRuszyc(object _x, int y)
        {
            int x = ConvertPosition(_x);

            if (!base.MozeRuszyc(x, y))
            {
                return false;
            }

            int posX = GetX();
            int posY = GetY();

            int diffY = Math.Abs(y - posY);
            int diffX = Math.Abs(x - posX);

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


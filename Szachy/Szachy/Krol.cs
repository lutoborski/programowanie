using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    class Krol : Figura
    {
        public Krol(object x, int y, int kolor) : base(x, y, kolor)
        {
            nazwa = "Król";
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

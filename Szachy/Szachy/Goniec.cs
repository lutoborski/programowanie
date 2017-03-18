using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
        class Goniec : Figura
        {
            public Goniec(object x, int y, int kolor) : base(x, y, kolor)
            {
                nazwa = "Goniec";
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

                if (diffX == diffY)
                {
                    return true;
                }

                return false;
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
        public static class Ruch
        {
            public static Figura inst(NazwaFigury figura, char X, int Y, Kolory kolor)
            {
                Figura figure = null;

                switch (figura)
                {
                    case NazwaFigury.Król:
                        {
                            figure = new Krol(X, Y, kolor);
                            break;
                        }

                    case NazwaFigury.Wieża:
                        {
                            figure = new Wieza(X, Y, kolor);
                            break;
                        }

                    case NazwaFigury.Goniec:
                        {
                            figure = new Goniec(X, Y, kolor);
                            break;
                        }
                    case NazwaFigury.Hetman:
                        {
                            figure = new Hetman(X, Y, kolor);
                            break;
                        }
                }

                return figure;
            }
        }
    }

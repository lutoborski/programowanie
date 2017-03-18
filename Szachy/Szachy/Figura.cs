using System;

namespace Szachy
{
    abstract class Figura
        {
            public enum Kolory : int
            {
                White = 0,
                Black = 1
            };

            public string nazwa;
            public int x;
            public int y;
            public int kolor;

        public Figura(object _x, int y, int kolor)
        {
            int x = ConvertPosition(_x);

            SetPozycja(x, y);
            SetKolor(kolor);
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public void SetPozycja(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetKolor(int kolor)
        {
            this.kolor = kolor;
        }
        public virtual bool MozeRuszyc(object _x, int y)
        {
            int x = ConvertPosition(_x);

            if (x > 8 || x < 1 || y > 8 || y < 1)
            {
                return false;
            }

            if (IsEqualPosition(x, y))
            {
                return false;
            }

            return true;
        }

        public int ConvertPosition(object pos)
        {
            if (pos is char)
            {
                return (int)Char.ToUpper(Convert.ToChar(pos)) - 64;
            }

            return Convert.ToInt32(pos);
        }

        public bool IsEqualPosition(int x, int y)
        {
            return GetX() == x && GetY() == y;
        }

    }
}

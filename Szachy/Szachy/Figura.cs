using System;

namespace Szachy
{
    public enum NazwaFigury
    {
        Goniec,
        Wieża,
        Król,
        Hetman
    }
    public enum Kolory
    {
        White,
        Black
    };
    public abstract class Figura
        {
            public string nazwa;
            public char x;
            public int y;
            public Kolory kolor;
            public delegate void Delegata();
            public event Delegata Zdarzenie;
        public char X
        {
            get { return x; }
            set { x = value;
                if (Zdarzenie != null) Zdarzenie();
            }
        }

        public int Y
        {
            get { return y; }
            set { y = value;
               if (Zdarzenie != null) Zdarzenie();
            }
        }

        public Kolory Kolor
        {
            get { return kolor; }
            set { kolor = value; }
        }

        public string NazwaFigury
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        public Figura(char x, int y, Kolory kolor)
        {
            X = x;
            Y = y;
            Kolor = kolor;

        }

        public string GetPozycjaString()
        {
            return $"{X}{Y}";

        }

        public string GetKolorString()
        {
            return Enum.GetName(typeof(Kolory), Kolor);
        }


        public override string ToString()
        {
            return $"Figura: {NazwaFigury}, kolor: {GetKolorString()}, pozycja: {GetPozycjaString()}, została przesunięta.";
        }
        public virtual bool MozeRuszyc(char x, int y)
        {
            int liczbaX = ConvertPosition(x);

            if ((liczbaX < 1 || liczbaX > 8) || (y < 1 || y > 8))
            {
                return false;
            }

            if (IsEqualPosition(x, y))
            {
                return false;
            }

            return true;
        }

        public int ConvertPosition(char position)
        {
            return (int)Char.ToUpper(position) - 64;
        }

        public bool IsEqualPosition(int x, int y)
        {
            return X == x && Y == y;
        }
    }
}

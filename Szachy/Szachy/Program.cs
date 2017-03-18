using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    class Szachy
    {
        static void Main(string[] args)
        {   
            Figura wieza = new Wieza('C', 6, 1);
            Figura hetman = new Hetman('F', 5, 1);
            Figura goniec = new Goniec('D', 3, 0);
            Figura krol = new Krol('F', 2, 0);

            Console.WriteLine("Czarna wieża może ruszyć z C6 na H6: {0}", (wieza.MozeRuszyc('H', 6)));
            Console.WriteLine("Czarna wieża może ruszyć z C6 na C3: {0}", (wieza.MozeRuszyc('C', 3)));
            Console.WriteLine("Czarna wieża może ruszyć z C6 na E4: {0}", (wieza.MozeRuszyc('E', 4)));

            Console.WriteLine("Czarny hetman może ruszyć z F5 na H5: {0}", (hetman.MozeRuszyc('H', 5)));
            Console.WriteLine("Czarny hetman może ruszyć z F5 na F2: {0}", (hetman.MozeRuszyc('F', 2)));
            Console.WriteLine("Czarny hetman może ruszyć z F5 na C8: {0}", (hetman.MozeRuszyc('C', 8)));
            Console.WriteLine("Czarny hetman może ruszyć z F5 na C4: {0}", (hetman.MozeRuszyc('C', 4)));

            Console.WriteLine("Biały goniec może ruszyć z D3 na B1: {0}", (goniec.MozeRuszyc('B', 1)));
            Console.WriteLine("Biały goniec może ruszyć z D3 na F5: {0}", (goniec.MozeRuszyc('F', 5)));
            Console.WriteLine("Biały goniec może ruszyć z D3 na G2: {0}", (goniec.MozeRuszyc('G', 2)));
            Console.WriteLine("Biały goniec może ruszyć z D3 na D6: {0}", (goniec.MozeRuszyc('D', 6)));

            Console.WriteLine("Biały król może ruszyć z F2 na E3: {0}", (krol.MozeRuszyc('E', 3)));
            Console.WriteLine("Biały król może ruszyć z F2 na G2: {0}", (krol.MozeRuszyc('G', 2)));
            Console.WriteLine("Biały król może ruszyć z F2 na F1: {0}", (krol.MozeRuszyc('F', 1)));
            Console.WriteLine("Biały król może ruszyć z F2 na D4: {0}", (krol.MozeRuszyc('D', 4)));

            Console.ReadKey();
        }
    }
}

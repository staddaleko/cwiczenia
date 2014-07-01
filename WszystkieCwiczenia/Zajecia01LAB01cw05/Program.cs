using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie05
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Napisz program, który znajduje największy wspólny dzielnik (NWD) dwóch liczb naturalnych. Problemu 
            //ten rozwiązuje algorytm Euklidesa. Nie wymaga on rozkładania liczb na czynniki pierwsze. Co ciekawe 
            //algorytmu nie wymyślił Euklides, a Eudoksos z Knidos – grecki filozof i matematyk. Euklides jedynie 
            //algorytm ten zawarł w swoim dziele Elementy. Data powstania algorytmu około 300 lat p.n.e. 

            ulong m, n, roznica;
            Console.WriteLine("Znajdźmy największy wspólny dzielnik...");
            Console.WriteLine("Podaj wartość m: ");
            m = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Podaj wartość n: ");
            n = Convert.ToUInt64(Console.ReadLine());
            //            Wykonuj póki wartość zmiennej roznica będzie różna od zera następujące polecenia.  
            //Od większej liczby odejmij mniejszą, wynik podstaw do zmiennej różnica. Do większej liczby z m 
            //i n podstaw wartość zmiennej roznica.  
            do
            {
                roznica = m > n ? m - n : n - m;
                if (n > m)
                {
                    n = roznica;
                }
                else
                {
                    m = roznica;
                }
            } while (roznica != 0);

            Console.WriteLine("Największy wspólny dzielnik podanych liczb to {0}", n);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program obliczający sumę i iloczyn n pierwszych liczb naturalnych podzielnych przez k, gdzie k 
            //oraz n są dowolnymi liczbami naturalnymi. 
            ulong iloczyn = 1, suma = 0;
            ushort a, k, n;
            Console.WriteLine("program obliczający sumę i iloczyn n pierwszych liczb naturalnych \npodzielnych przez k, gdzie k oraz n są dowolnymi liczbami naturalnymi. ");
            Console.WriteLine("Podaj wartość zmiennej n: ");
            n = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Podaj wartość zmiennej k: ");
            k = Convert.ToUInt16(Console.ReadLine());
            a = k;
            //Wykonaj n razy następujące polecenia 
            //i.  Wartość zmiennej suma zwiększ o wartość zmiennej a. 
            //ii.  Wartość zmiennej iloczyn zwiększ a razy. Zapewnij, że w razie przepełnienia, zostanie 
            //zgłoszony wyjątek. 
            //iii.  Do zmiennej a podstaw wartość kolejnej liczby podzielnej przez k. 
            for (int i = 0; i < n; i++)
            {
                suma += a;
                checked
                {
                    iloczyn *= a;
                }
                a += k;
                Console.WriteLine("suma = {0}", suma);
                Console.WriteLine("iloczyn={0}", iloczyn);
                Console.ReadKey();
            }
        }
    }
}

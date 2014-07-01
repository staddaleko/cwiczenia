using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie02
{
    class Program
    {
        static double Wielomian(double x, params double[] a)
        {
            double suma = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                suma = suma * x + a[i];
            }
            return suma;
        }
        static double Wielomian(double x, out double stopien, params double[] a)
        {
            stopien = a.Length - 1;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] != 0)
                {
                    break;
                }
                stopien--;
            }
            return Wielomian(x, a);
        }

        static void Main(string[] args)
        {
            #region Wprowadzenie
            /*Napisz dwie metody obliczające wartość wielomianu metodą Hornera. Pierwsza metoda oblicza tylko wartość wielomianu dla wartości x podanej jako argument metody i zwraca ją do programu. Współczynniki wielomianu przesyłane są jako parametr z modyfikatorem params (dowolna ilość argumentów). Druga metoda dodatkowo oblicza stopień wielomianu - argument przesyłany jako parametr wyjściowy. W metodzie Hornera stosuje się następujące przekształcenie : a0xn + a1xn-1 + a2xn-2 +... +an-1x1 + an = (...((a0x + a1)*x + a2)*x+...+an-1)*x + an. W wyniku zastosowania powyższego przekształcenia zmniejszamy ilość wykonywanych działań i zwiększamy dokładność obliczonego wyniku. */
            #endregion

            double stopienWielomianu;
            double[] wspolczynnikiWielomianu = { 1, 1, 0, 1 };

            Console.WriteLine("Wartość wielomianu obliczona pierwszą metodą {0}", Wielomian(1, wspolczynnikiWielomianu));
            Console.WriteLine("Wartość wielomianu obliczona drugą metodą {0}", Wielomian(1, out stopienWielomianu, wspolczynnikiWielomianu));
            Console.WriteLine("Stopień wielomianu: {0}", stopienWielomianu);

            Console.WriteLine("\nInny sposób przekazania wartości współczynników wielomianu do metody");
            Console.WriteLine("Wartość wielomianu obliczona pierwszą metodą {0}", Wielomian(1, 0, 1, 2));
            Console.WriteLine("Wartość wielomianu obliczona drugą metodą {0}", Wielomian(1, out stopienWielomianu, 0, 1, 2));
            Console.WriteLine("Stopień wielomianu: {0}", stopienWielomianu);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, grę - zgadnij liczbę. Użytkownik ma zgadnąć liczbę wylosowaną przez komputer. Do 
            //wylosowania liczby pseudolosowej stosuj następujący kod. 
            //Random generator = new Random(); 
            //int liczba = generator.Next(a, b +1); 
            const int a = 0;
            const int b = 200;
            int n, m;
            Random generator = new Random();
            n = generator.Next(a, b + 1);
            //  Wykonuj następujące instrukcje, póki użytkownik nie zgadnie wylosowanej wartości:  
            //i.  Pobierz wartość zmiennej m od użytkownika. 
            //ii.  Poinformuj użytkownika, czy podana przez niego liczba jest za duża albo za mała.
            Console.Write(n);
            do
            {
                Console.WriteLine("Podaj wartość wylosowanej liczby.\nWartość jest z przedziału <{0}, {1}>: ", a, b);
                m = Convert.ToInt32(Console.ReadLine());
                if (m < n)
                {
                    Console.WriteLine("Wartość podana jest za mała!!!");
                }
                if (m > n)
                {
                    Console.WriteLine("Wartość podana jest za duża!!!");
                }

            } while (m != n);
            Console.WriteLine("Gratulacje! Odgadłeś liczbę!");
            Console.ReadKey();
        }
    }
}

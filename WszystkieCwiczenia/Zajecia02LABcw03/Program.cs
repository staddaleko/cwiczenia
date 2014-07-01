using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie03
{
    class Program
    {
        static void Przesiewaj(double[] tab, uint l, uint p)
        {
            uint i = l, j = 2 * i + 1;
            double x = tab[i];
            while (j <= p)
            {
                if (j < p)
                {
                    if (tab[j] < tab[j + 1])
                    {
                        j++;
                    }
                    if (tab[j] < x)
                    {
                        break;
                    }
                }
                tab[i] = tab[j];
                i = j;
                j = 2 * i + 1;
            }
            if (i != l)
            {
                tab[i] = x;
            }
        }

        static void Przesiewaj(string[] tab, uint l, uint p)
        {
            uint i = l, j = 2 * i + 1;
            string x = tab[i];
            while (j <= p)
            {
                if (j < p)
                {
                    if (string.Compare(tab[j], tab[j + 1]) < 0)
                    {
                        j++;
                    }
                    if (string.Compare(tab[j], x) < 0)
                    {
                        break;
                    }
                    tab[i] = tab[j];
                    i = j;
                    j = 2 * i + 1;
                }
            }
            if (i != 1)
            {
                tab[i] = x;
            }

        }

        static void Sortuj(double[] tab)
        {
            uint l = (uint)tab.Length / 2, p = (uint)tab.Length - 1;
            double x;
            while (l > 0)
            {
                l--;
                Przesiewaj(tab, l, p);
            }
            while (p > 0)
            {
                x = tab[0];
                tab[0] = tab[p];
                tab[p] = x;
                p--;
                Przesiewaj(tab, 0, p);
            }
        }

        static void Sortuj(string[] tab)
        {
            uint l = (uint)tab.Length / 2, p = (uint)tab.Length - 1;
            string x;
            while (l > 0)
            {
                l--;
                Przesiewaj(tab, l, p);
            }
            while (p > 0)
            {
                x = tab[0];
                tab[0] = tab[p];
                tab[p] = x;
                p--;
                Przesiewaj(tab, 0, p);
            }
        }

        static void Main(string[] args)
        {
            #region opis zadania
            /*Napisz dwie metody sortujące tablice. Pierwsza niech sortuje tablice liczb rzeczywistych. Druga metoda 
będzie sortowała tablice napisów. Do porównania dwóch napisów użyj metody String.Compare(string s1,string s2). Metoda ta zwraca wartość mniejszą od zera, gdy s1 jest "mniejsze" od s2, wartość zero gdy oba napisy są jednakowe oraz wartość większą od zera gdy s1 jest później w kolejności alfabetycznej niż s2. Więcej na temat metody Compare można znaleźć w MSDN Library. Do sortowania użyj algorytmu sortowania przez kopcowanie (heap sort). Podstawą tej metody jest tworzenie tzw. kopca. Kopiec definiujemy jako ciąg elementów tablicy a[p], a[p+1], ..., a[q] spełniających następujące warunki:  
  a[i]>=a[2i+1]  
  a[i]>=a[2i+2] 
dla wszystkich i = p, ..., (q-1)/2 */

            #endregion

            double[] tab = { 2.3, 3, 45, 12.3, 4.3, 7.2 };
            Console.WriteLine("Tablica liczb rzeczywistych przed sortowaniem");
            foreach (double d in tab)
            {
                Console.Write("{0}; ", d);
                Sortuj(tab);
                Console.WriteLine("Tablica liczb rzeczywistych po sortowaniu");
                foreach (double dd in tab)
                {
                    Console.Write("{0}; ", dd);
                }
                Console.WriteLine("\n\n*********************\n");
                string[] napisy = { "szafa", "Szwecja", "stóg", "szampan", "Słowacja" };
                Console.WriteLine("Tablica wyrazów przed sortowaniem:");
                foreach (string s in napisy)
                {
                    Console.Write("{0}; ", s);
                }
                Sortuj(napisy);
                Console.WriteLine("Tablica wyrazów po sortowaniu:");
                foreach (string s in napisy)
                {
                    Console.Write("{0}; ", s);
                }
                Console.ReadKey();

            }
        }
    }
}

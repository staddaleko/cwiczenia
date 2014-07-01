using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie14
{
    class Program
    {
        static void Main(string[] args)
        {
            #region opis
            //Napisz program, który sortuje tablicę metodą przez wstawianie. Tablicę zainicjalizuj liczbami 
            //pseudolosowymi, korzystając z generatora liczb pseudolosowych: 
            //Random r = new Random();  //utworzenie obiektu  
            //      //generatora liczb pseudolosowych 
            //double n = r.NextDouble();    //losowanie liczby 
            //      //rzeczywistej z przedziału <0;1> 
            //Metoda sortowania przez wstawianie (insertion sort) jest podobna do sposobu, jaki stosujemy przy 
            //układaniu kart. Tablice dzielimy na umowne dwie podtablice. Pierwsza podtablica jest posortowana. 
            //Druga podtablica jest źródłem elementów, które należy wstawić w odpowiednie miejsce w tablicy 
            //pierwszej. Oczywiście po wstawieniu elementu, rozmiar podtablicy posortowanej jest zwiększany o 
            //jeden, natomiast rozmiar podtablicy źródłowej zmniejszany o jeden. Sortowanie rozpoczynamy od 
            //założenia, że podtablica posortowana zawiera tylko jeden element - pierwszy element tablicy. 
            //Sortowanie kończymy w momencie, kiedy w podtablicy źródłowej nie ma więcej elementów.  
            #endregion

            double[] tablica = new double[15];
            Random generator = new Random();
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = generator.NextDouble();
            }
            Console.WriteLine("Wylosowano następujące wartości: ");
            foreach (double i in tablica)
            {
                Console.Write("{0:f3}; ", i);
            }
            #region polecenie
            //              Podziel tablicę na dwie części, podtablicę źródłową i podtablicę posortowaną. Pobieraj 
            //elementy z podtablicy źródłowej, od pierwszego elementu i wstawiaj w odpowiednie miejsce 
            //w podtablicy posortowanej. Czynność powtarzaj póki podtablica posortowana nie będzie 
            //pusta.  
            #endregion
            //double x;
            //int j;
            //for (int i = 1; i < tablica.Length; i++)
            //{
            //    x = tablica[i];
            //    for (int j = i-1; j >=0 && x<tablica[j]; j--)
            //    {
            //        tablica[j + 1] = tablica[j];
            //    }
            //    tablica[j + 1] = x;
            #region Uwaga
            /*
Uwaga: 
Podczas wstawiania można wykorzystać wyszukiwanie połówkowe. Powyższy kod można 
zastąpić wtedy następującym: 
*/
            int j, l, p, m;
            double x;
            for (int i = 1; i < tablica.Length; i++)
            {
                x = tablica[i];
                l = 0; p = i - 1;
                while (l <= p)
                {
                    m = (l + p) / 2;
                    if (x < tablica[m])
                        p = m - 1;
                    else
                        l = m + 1;
                }
                for (j = i - 1; j >= l; j--)
                {
                    tablica[j + 1] = tablica[j];
                }
                tablica[j + 1] = x;
            }


            #endregion
            Console.WriteLine("\n\nElementy tablicy po sortowaniu: ");
            foreach (double i in tablica)
            {
                Console.Write("{0:f3}; ", i);
            }
            Console.ReadKey();
        }
    }
}


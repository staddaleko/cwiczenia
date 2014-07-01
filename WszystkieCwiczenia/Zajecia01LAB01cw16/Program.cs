using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie16
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Napisz program, który w celu sprawdzenia czy w tablicy znajduje się element o danej wartości stosuje 
            //algorytm wyszukiwania binarnego. Użyj tablicy zawierającej napisy. Do porównania dwóch obiektów 
            //string, czy zawierają ten sam napis, użyj metody String.Compare(napis1, napis2). 
            //Metoda ta zwraca wartość mniejszą od zera, gdy napis1 "jest mniejszy" od napis2 (jest wcześniej 
            //w słowniku). Wartość zero oznacza, że obie zmienne zawierają uchwyt do obiektów z tym samym 
            //tekstem. Wartość większa od zera oznacza, że napis1 "jest większy" od napis2 (występuje 
            //później w słowniku). 

            string[] miasta = { "Poznań", "Gdańsk", "Łódź", "Kraków", "Wrocław", "Białystok", "Szczecin" };
            Array.Sort(miasta);
            Console.WriteLine("Elementy tablicy po sortowaniu: ");
            foreach (string miasto in miasta)
            {
                Console.Write("{0}, ", miasto);
            }
            Console.Write("Podaj nazwę miasta: ");
            string s = Console.ReadLine();
            int lewy = 0, prawy = miasta.Length - 1;
            int srodek = (lewy + prawy) / 2;

            //            Póki wartość zmiennej lewy jest mniejsza lub równa od wartości zmiennej prawy, wykonuj 
            //co następuje: 
            //i.  Jeżeli element o indeksie równym wartości zmiennej srodek zawiera miasto takie jak 
            //podał użytkownik zakończ pętlę. 
            //ii.  Jeżeli element o indeksie równym wartości zmiennej srodek zawiera miasto, które w 
            //kolejności alfabetycznej występuje przed miastem podanym przez użytkownika, zmiennej 
            //prawy nadaj wartość zmiennej srodek pomniejszoną o jeden. 
            //iii.  Jeżeli element o indeksie równym wartości zmiennej srodek zawiera miasto, które w 
            //kolejności alfabetycznej występuje po mieście podanym przez użytkownika, zmiennej 
            //lewy nadaj wartość zmiennej srodek powiększoną o jeden. 
            //iv.  Zmiennej srodek nadaj wartość równą połowie sumy wartości zmiennej lewy i prawy. 

            int flaga;
            while (lewy <= prawy)
            {
                flaga = string.Compare(s, miasta[srodek]);
                if (flaga == 0)
                {
                    break;
                }
                else
                {
                    if (flaga < 0)
                    {
                        prawy = srodek - 1;
                    }
                    else
                    {
                        lewy = srodek + 1;
                    }
                }
                srodek = (lewy + prawy) / 2;

                //Jeżeli wartość zmiennej lewy jest mniejsza lub równa od wartości zmiennej prawy, wypisz na 
                //ekranie informację, że tablica zawiera podane miasto, w przeciwnym wypadku wypisz, że 
                //tablica nie zawiera podanego miasta. Następnie zatrzymaj program, aby użytkownik mógł 
                //obejrzeć wyniki. 

                if (lewy <= prawy)
                {
                    Console.Write("Podane miasto ma w tablicy indeks {0}, ", srodek);
                }
                else
                {
                    Console.Write("Tablica nie zawiera podanego miasta");
                }
                Console.ReadKey();
            }
        }
    }
}

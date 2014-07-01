using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Opis zadania
            //            Napisz programu, który będzie wyznaczał wszystkie liczby pierwsze w zadanym przedziale. Program 
            //będzie korzystał z algorytmu zwanego sitem Eratostenesa. Algorytm ten polega na tym, że tworzymy 
            //zbiór wszystkich liczb naturalnych z danego przedziału większych lub równych dwa. Następnie 
            //wybieramy ze zbioru najmniejszą liczbę, czyli dwa i usuwamy wszystkie jej wielokrotności. Wybrana 
            //liczba jest liczbą pierwszą. Po usunięciu ze zbioru wszystkich wielokrotności liczby dwa, wybieramy 
            //kolejną najmniejszą liczbę. Będzie to kolejna liczba pierwsza. Usuwamy jej wszystkie wielokrotności i 
            //znowu wybieramy najmniejszą liczbą ze zbioru i usuwamy jej wielokrotności. Czynności wybierania i 
            //usuwania powtarzamy, dopóki nie opróżnimy zbioru. Wybrane liczby będą szukanymi liczbami 
            //pierwszymi. 
            //Implementacja tego algorytmu polega na utworzeniu tablicy logicznej o liczbie elementów równej 
            //ilości liczb naturalnych większych lub równych dwa w danym przedziale. Pierwszy element tablicy 
            //odpowiada liczbie dwa, drugi liczbie trzy itd. Zakładamy, że wszystkie liczby są liczbami pierwszymi, 
            //co realizujemy przez ustalenie jednakowej wartości dla wszystkich elementów tablicy - np. false 
            //gdyż tak domyślnie są inicjalizowane elementy tablic logicznych. Wybieramy pierwszy element 
            //tablicy, który ma wartość false. Jest to oczywiście pierwszy element tablicy, który reprezentuje 
            //liczbę dwa. Usunięcie wielokrotności liczby dwa, będzie polegało na nadaniu elementom tablicy 
            //reprezentującym te wielokrotności wartości true, bez zmieniania wartości wybranego elementu. Po 
            //nadaniu wszystkim elementom tablicy reprezentującym wielokrotność liczby dwa wartości true, 
            //wybieramy kolejny element tablicy o wartości false. Wartość elementów tablicy reprezentujących 
            //wielokrotności wybranego elementu ustawiamy na true. Czynności wyboru elementu i ustawienia 
            //wartości elementów reprezentujących jego wielokrotności na true, powtarzamy aż do momentu, 
            //gdy nie mamy do wyboru następnego elementu tablicy, którego wartość jest równa false. 
            //Elementy tablicy, które mają wartość false, reprezentują liczby pierwsze w danym przedziale. 
            //Do algorytmu powyższego warto dodać pewne usprawnienia. Niektóre liczby są wielokrotnościami 
            //kilku liczb i nadawanie elementom je reprezentującym wartości true (usuwanie) wykonywane jest 
            //wiele razy. Zupełnie nie uda nam się tego zlikwidować, ale można to zoptymalizować.  
            //Pierwszą wielokrotnością, którą będziemy "usuwać", będzie wartość równa kwadratowi wybranej 
            //liczby pierwszej, ponieważ mniejsze wielokrotności musiały być równe iloczynowi wybranej liczby 
            //pierwszej i liczby od niej mniejszej, więc musiały juz być "usunięte" wcześniej.  
            //Wybieranie liczb pierwszych należy zakończyć po osiągnięciu pierwiastka kwadratowego końca 
            //przedziału. Wybór większej liczby nie powoduje już "usunięcia" więcej wielokrotności - patrz pierwsza 
            //optymalizacja.  
            #endregion

            ulong n;
            Console.WriteLine("Podaj górną granicę przedziału \nz którego chcesz wypisać wszystkie liczby pierwsze.");
            Console.Write("Liczba nie może być większa od {0}. ", ulong.MaxValue);
            n = Convert.ToUInt64(Console.ReadLine());

            bool[] liczby = new bool[n - 1];
            //W wyniku powyższej deklaracji, każdy element tablicy ma nadaną domyślnie wartość false. 
            //Tablica o rozmiarze n-1, bo nie bierzemy pod uwagę liczby jeden. 

            //Dla wszystkich liczb całkowitych od liczby dwa do liczby równej pierwiastkowi kwadratowemu 
            //z wartości końca przedziału, wykonuj co następuje: 
            //i.  Sprawdź czy wartość elementu reprezentującą wybraną liczbę jest równa false. 
            //ii.  Jeżeli wartość jest równa false, ustaw wartości elementów tablicy reprezentujących 
            //wielokrotności wybranej liczby na wartość false. Rozpocznij od liczby równej 
            //kwadratowi wybranej liczby. 
            //ii.  Następnie przejdź do następnej liczby. 

            ulong m = (uint)Math.Sqrt(n);
            ulong index;
            for (ulong i = 2; i <= m; i++)
            {
                if (!liczby[i - 2])
                {
                    index = i * i - 2;
                    while (index < n - 1)
                    {
                        liczby[index] = true;
                        index += i;
                    }
                }
            }
            Console.WriteLine("Liczby pierwsze z podanego przedziału to: ");
            int j = 0;
            for (ulong i = 0; i < n - 1; i++)
            {
                if (!liczby[i])
                {
                    Console.Write("{0,22}, ", i + 2);
                    j++;
                    if (j % 2 == 0)
                    {
                        Console.WriteLine();
                    }
                    if (j % (2 * Console.WindowHeight) == 0)// WTF?!
                    {
                        Console.ReadKey();
                    }
                }
            }
            Console.Write("\nLiczb pierwszych w podanym przeziale jest {0}", j);
            Console.ReadKey();
        }
    }
}

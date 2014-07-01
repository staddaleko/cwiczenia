using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Napisz program rozwiązujący problem ośmiu hetmanów. Problem ośmiu hetmanów polega na umieszczeniu na szachownicy ośmiu hetmanów tak, aby żaden nie był na drodze ruchu innego hetmana, czyli nie był pod biciem. Hetman może poruszać się po polach kolumny, wiersza lub przekątnych do których należy pole, na którym znajduje się hetman.
 * 
 * Przy pisaniu programu skorzystaj ze schematu przedstawionego na slajdzie "Algorytmy z powrotami", programu droga skoczka oraz następujących wskazówek:  Metoda Sprawdz przyjmuje jako argument numer kolumny, na której chcemy ustawić hetmana. Ustawiamy hetmana najpierw w pierwszej kolumnie, w miejscu wybranym przez użytkownika, następnie przechodzimy do następnej kolumny.  W następnych kolumnach, próbujemy ustawić hetmana na polu tej kolumny, rozpoczynając od wiersz pierwszego. Jeżeli istnieje pole, które jest nieatakowane przez pozostałych hetmanów, zaznaczamy je i przechodzimy do następnej kolumny wywołując ponownie metodę Sprawdz. Jeżeli metoda Sprawdz przekazała wartość true, oznacza to że problem został rozwiązany. W przeciwnym wypadku sprawdzamy następne wiersze, wcześniej odznaczając poprzednie pole jako nieatakowane. Jeżeli żaden wiersz nie daje oczekiwanego rezultatu, wychodzimy z metody (cofamy się) zwracając wartość false..  W celu sprawdzenia czy pole jest nieatakowane skorzystaj z pomocniczych tablic: 
o Tablicy boolowskiej Wiersze, o liczbie pól równej liczbie wierszy, element Wiersze [0] odpowiada wierszowi pierwszemu, itd. Wartość false elementu oznacza, że odpowiadający mu wiersz jest wolny, wartość true, że wiersz jest zajęty 
o Dwóch tablic boolowskich dla przekątnych. Jedna tablica będzie zawierać informacje o przekątnych biegnących z góry na dół, druga o przekątnych z dołu do góry. Każdy element tablicy odpowiada pojedynczej przekątnej. Podobnie jak poprzednio, wartość false elementu oznacza, że odpowiadająca mu przekątna jest wolna, wartość true, że przekątna jest zajęta. Zauważ, że dla pól należących do jednej przekątnej biegnącej z góry na dół, suma numeru jego kolumny i wiersza jest stała, natomiast dla pól należących do jednej przekątnej biegnącej z dołu do góry różnica numeru jego kolumny i wiersza jest stała.   Informację gdzie ustawiono poszczególnych hetmanów, przechowuj w tablicy liczb całkowitych. Indeks elementu tablicy oznacza numer kolumny, wartość elementu tablicy zawiera numer wiersz, gdzie stoi hetman 
 * 
 * 
 */


namespace Zajecia02LABcw05
{
    class Program
    {
        const int RozmiarSzachownicy = 8;

        static byte[] kolumny = new byte[RozmiarSzachownicy];
        static bool[] wiersze = new bool[RozmiarSzachownicy];
        static bool[] przekatneDol = new bool[2 * RozmiarSzachownicy - 1];
        static bool[] przekatneGora = new bool[2 * RozmiarSzachownicy - 1];

        static bool Sprawdz(int nrKolumny)
        {
            for (int wiersz = 0; wiersz < RozmiarSzachownicy; wiersz++)
            {
                if (wiersze[wiersz])
                    continue;
                if (przekatneDol[wiersz + nrKolumny])
                    continue;
                if (przekatneGora[wiersz - nrKolumny + RozmiarSzachownicy - 1])
                    continue;
                kolumny[nrKolumny] = (byte)(wiersz + 1);
                wiersze[wiersz] = true;
                przekatneDol[wiersz + nrKolumny] = true;
                przekatneGora[wiersz - nrKolumny + RozmiarSzachownicy - 1] = true;
                if (nrKolumny == 7)
                    return true;
                if (Sprawdz(nrKolumny + 1))
                    return true;
                kolumny[nrKolumny] = 0;
                wiersze[wiersz] = false;
                przekatneDol[wiersz + nrKolumny] = false;
                przekatneGora[wiersz - nrKolumny + RozmiarSzachownicy - 1] = false;
            }
            return false;
        }

        static void WypiszRozwiazanie()
        {
            char c = 'A';
            for (int i = 0; i < RozmiarSzachownicy; i++, c++)
            {
                Console.Write("{0}{1}, ", c, kolumny[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj pozycje hetmana w pierwszej kolumnie: wartość od 1 do {0}: ", RozmiarSzachownicy);

            int nrWiersza = Convert.ToInt32(Console.ReadLine()) - 1;
            kolumny[0] = (byte)(nrWiersza + 1);
            wiersze[nrWiersza] = true;
            przekatneDol[nrWiersza] = true;
            przekatneGora[nrWiersza + RozmiarSzachownicy - 1] = true;

            if (Sprawdz(1))
            {
                WypiszRozwiazanie();
            }
            else
            {
                Console.WriteLine("Rozwiązanie nie istnieje!!!");
            }
            Console.ReadKey();
        }
    }
}


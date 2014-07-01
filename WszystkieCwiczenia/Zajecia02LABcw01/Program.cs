using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie1
{
    class Program
    {
        static decimal cenaBrutto, kwotaWplacona, cenaNetto;
        const decimal StawkaPodatku = 0.23m;

        //  Utwórz metodę Pobierz, która będzie pobierać od użytkownika cenę netto towaru i obliczać cenę 
        //brutto. Następnie wypisze cenę brutto i pobierze kwotę wpłaconą przez klienta. Jeżeli cena towaru 
        //brutto jest większa od kwoty wpłaconej przez użytkownika zgłoś wyjątek. Po pobraniu obu wartości 
        //(ceny netto i kwoty podanej przez klienta) oraz po obliczeniu ceny brutto zaokrąglij wszystkie wartości 
        //do dwóch miejsc po przecinku przy pomocy metody Round struktury Decimal.  
        //cenaNetto = Decimal.Round(cenaNetto, 2); 
        //Pilnuj aby wartości wprowadzone były większe od zera.
        static void Pobierz()
        {
            do
            {
                Console.Write("\nPodaj cenę netto towaru zakupionego przez klienta: ");
                cenaNetto = Convert.ToDecimal(Console.ReadLine());
            } while (cenaNetto < -0);
            cenaNetto = decimal.Round(cenaNetto, 2);
            cenaBrutto = decimal.Round(cenaNetto * (1 + StawkaPodatku), 2);
            Console.WriteLine("cena brutto wynosi: {0:C}", cenaBrutto);
            do
            {
                Console.WriteLine("\nPodaj kwotę wpłaconą przez klienta: ");
                kwotaWplacona = Convert.ToDecimal(Console.ReadLine());
            } while (kwotaWplacona <= 0);
            kwotaWplacona = decimal.Round(kwotaWplacona, 2);
            if (cenaBrutto > kwotaWplacona)
            {
                throw new Exception("Cena towaru nie może być większa od kwoty zapłaconej przez Klienta!");
            }

        }

        //Utwórz metodę Wypisz, która wypisuje na ekranie kwotę wpłaconą przez klienta, cenę brutto, cenę 
        //netto, kwotę podatku.  
        static void Wypisz()
        {
            Console.WriteLine("\n\n\n*******************");
            Console.WriteLine("\nKwota wpłacona przez Klienta: {0:C}", kwotaWplacona);
            Console.WriteLine("\ncena netto: {0:C}", cenaNetto);
            Console.WriteLine("\ncena brutto: {0:C}", cenaBrutto);
            Console.WriteLine("\nwartość podatku: {0:C}", cenaBrutto - cenaNetto);
        }

        //        Utwórz metodę Reszta, która wypisuje na ekranie ilość poszczególnych banknotów i monet, które 
        //trzeba dać klientowi, aby wydać mu resztę. Rozpocznij od obliczenia ilości banknotów 100 zł, następnie 
        //20 zł, 10 zł itd. 
        static void Reszta()
        {
            decimal reszta = kwotaWplacona - cenaBrutto;
            int ilosc = 0;
            Console.WriteLine("\nWartość reszty należnej klientowi: {0:C}", reszta);
            while (100 <= reszta)
            {
                ilosc++;
                reszta -= 100;
            }
            if (ilosc != 0)
            {
                Console.WriteLine("\tliczba banknotów {0:C}: {1}", 100, ilosc);
                ilosc = 0;
            }
            while (50 <= reszta)
            {
                ilosc++;
                reszta -= 50;
            }
            if (ilosc != 0)
            {
                Console.WriteLine("\tLiczba banknotów {0:C}: {1}", 50, ilosc);
                ilosc = 0;
            }
            while (20 <= reszta)
            {
                ilosc++;
                reszta -= 20;
            }
            if (ilosc != 0)
            {
                Console.WriteLine("\tLiczba banknotów {0:C}: {1}", 20, ilosc);
                ilosc = 0;
            }
            while (10 <= reszta)
            {
                ilosc++;
                reszta -= 10;
            }
            if (ilosc != 0)
            {
                Console.WriteLine("\tLiczba banknotów {0:C}: {1}", 10, ilosc);
                ilosc = 0;
            }
            while (5 <= reszta)
            {
                ilosc++;
                reszta -= 5;
            }
            if (ilosc != 0)
            {
                Console.WriteLine("\tLiczba monet {0:C}: {1}", 5, ilosc);
                ilosc = 0;
            }
            while (2 <= reszta)
            {
                ilosc++;
                reszta -= 2;
            }
            //if (ilosc != 0)
            //{
            //    Console.WriteLine("\tLiczba monet {0:C}: {1}", 2, ilosc);
            //    ilosc = 0;
            //} 
            //while (1 <= reszta)
            {
                ilosc++;
                reszta -= 1;
            }
            if (ilosc != 0)
            {
                Console.WriteLine("\tLiczba monet {0:C}: {1} \noraz {2:0} groszy", 1, ilosc + 1, reszta * 100);
                ilosc = 0;
            }

        }

        static void Main(string[] args)
        {
            //            Napisz program wspierający pracę kasjera. Program pobiera cenę towaru zakupionego przez klienta oraz 
            //kwotę którą wpłaca klient, następnie wypisuje cenę brutto i kwotę podatku od danej ceny brutto oraz 
            //minimalną ilość banknotów i monet którą należy wydać klientowi w postaci reszty. Program podziel na 
            //metody: 
            //  metodę pobierającą cenę netto i obliczającą cenę brutto. Po obliczeniu ceny brutto wypisuje ją na 
            //ekranie i pobiera kwotę wpłaconą przez klienta. W przypadku gdy cena brutto towaru jest większa 
            //od kwoty wpłaconej zgłoś wyjątek. Stawkę podatku przechowuj w stałej nazwanej 
            //StawkaPodatku. 
            //  metodę wypisującą na ekranie cenę brutto, cenę netto, kwotę wpłaconą przez klienta i kwotę 
            //podatku.  
            //  metodę wypisującą jak wydać resztę klientowi. Zakładamy, że chcemy resztę wydać przy użyciu 
            //minimalnej ilości banknotów i monet. Najpierw wydajemy banknot lub monetę o największym 
            //dopuszczalnym nominale. Czynność powtarzamy, aż do wydania nic nie pozostanie. Algorytm 
            //powyższy funkcjonuje na zasadzie, że wykonuje się działanie, które wydaje się najlepsze w danej 
            //chwili, nie uwzględniając tego, jak to wpłynie na wynik(wydajność) w przyszłości. Algorytmy 
            //działające według tej zasady nazywamy algorytmami zachłannymi (greedy algorithm). 
            //  metody Main, która wywołuje w pętli powyższe metody. Metoda Main również obsługuje 
            //wyjątek zgłoszony przez metodę obliczającą cenę brutto towaru. 

            char c = 't';
            do
            {
                try
                {
                    Pobierz();
                    Wypisz();
                    Reszta();
                    Console.WriteLine("\n\nCzy jest jeszcze jakiś klient?");
                    c = Console.ReadKey().KeyChar;
                    Console.Beep();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            } while (c == 't' || c == 'T');
        }
    }
}

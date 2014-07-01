using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie09
{
    class Program
    {
        enum MetodyCalkowania { Prostokatow = 1, Trapezow = 2 };
        static void Main(string[] args)
        {
            //Napisz program obliczający całkę oznaczoną z funkcji nieujemnej i całkowalnej  na zadanym przedziale 
            //np. f(x) = x4 + x3 + 2. Użytkownik ma do wyboru: 
            //  metodę (metoda prostokątów lub metoda trapezów) 
            //  przedział całkowania 
            //  liczbę podziałów (podprzedziałów) 
            //Całkę oznaczaną w przedziale <a; b> z funkcji nieujemnej całkowalnej na przedziale <a, b> można 
            //interpretować jako pole obszaru ograniczonego wykresem tej funkcji, osią OX oraz prostymi x = a i x = 
            //b. 
            //W przypadku metody prostokątów, pole to przybliżamy, sumą pól odpowiednio dobranych prostokątów. 
            //Sposób postępowania jest następujący: Przedział całkowania <a; b> dzielimy na n równych 
            //podprzedziałów: <x0; x1>, <x1; x2>, ..., <xn-2; xn-1>, <xn-1; xn> 
            //Dla każdego punktu xi, gdzie i = 1...n, wyznaczamy wartość funkcji w tym punkcie. Będzie to długość 
            //jednego z boków prostokąta. Długość drugiego boku jest równa szerokości podprzedziału. Sumę pól 
            //prostokątów, a więc przybliżoną wartość całki, możemy zapisać wzorem: 
            //W przypadku metody trapezów, zamiast sumy pól prostokątów używamy sumę pól trapezów: 


            //Wewnątrz metody Main napisz następujący kod: 
            //a.  Zadeklaruj następujące zmienne i nadaj im wartości początkowe: 
            //i.  dwie zmienne rzeczywiste a i b, reprezentujące początek i koniec przedziału całkowania. a musi 
            //być mniejsze od b. 
            //ii.  Zmienną dodatnią n reprezentującą liczbę podziałów przedziału całkowania. 
            //iii.  Zmienną metoda typu MetodyCalkowania.             
            double a = 0, b = 1;
            uint n = 10;
            MetodyCalkowania metoda = MetodyCalkowania.Prostokatow;

            char c;
            do
            {
                //c.  W głównej pętli programu: 
                //i.  Wyświetl menu programu. Menu powinno zawierać informacje na temat: aktualnego przedziału 
                //całkowania, ilości podziałów i wybranej metody całkowania oraz jak zmienić przedział 
                //całkowania, metodę całkowania, liczbę podziałów, jak obliczyć całkę dla podanych parametrów 
                //i jak zakończyć program. 

                Console.WriteLine("Przedział całkowania: <{0}; {1}>", a, b);
                Console.WriteLine("Liczba podziałów: {0}", n);
                Console.WriteLine("Metoda całkowania: {0}", metoda);
                Console.WriteLine("------");
                Console.WriteLine("A - zmiana przedziału");
                Console.WriteLine("B - zmiana liczby przedziałów");
                Console.WriteLine("C - Zmiana metody całkowania");
                Console.WriteLine("D - Policz całkę");
                Console.WriteLine("K - Koniec");
                c = Console.ReadKey(true).KeyChar;


                switch (c)
                {
                    case 'a':
                    case 'A':
                        do
                        {
                            if (a > b)
                            {
                                Console.Write("Początek musi być mniejszy od końca...");
                            }
                            Console.Write("Podaj początek przedziału: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Podaj koniec przedziału: ");
                            b = Convert.ToDouble(Console.ReadLine());
                        } while (a > b);
                        break;
                    case 'b':
                    case 'B':
                        Console.Write("Podaj liczbę podziałów: ");
                        n = Convert.ToUInt32(Console.ReadLine());
                        if (n == 0)
                        {
                            throw new Exception("Liczba podziałów musi byc większa od zera!!!...");
                        }
                        break;
                    case 'c':
                    case 'C':
                        int m = 1;
                        do
                        {
                            if (m != 1)
                            {
                                Console.Write("Naciśnij 1 lub 2: ");
                                Console.WriteLine("Podaj metodę liczenia całki: ");
                                Console.WriteLine("\t1 - Metoda prostokątów");
                                Console.WriteLine("\t2 - Metoda trapezów: ");
                                m = Convert.ToInt32(Console.ReadLine());
                            }
                        } while (!(m == 1 || m == 2));
                        metoda = (MetodyCalkowania)m;
                        break;
                    //Obsługa liczenia całki 
                    case 'd':
                    case 'D':
                        double suma = 0;
                        double dx = (b - a) / n;
                        double x = a;

                        //W zależności od wartości zmiennej metoda, oblicz wartość całki i wstaw ją do zmiennej 
                        //suma. 

                        //Uwaga: 
                        //W celu optymalizacji obliczania wartości funkcji w punkcie, możemy skorzystać z 
                        //następującego przekształcenia: 
                        //                    f(x) = x4+x3+2 = x3(x+1)+2 

                        switch (metoda)
                        {
                            case MetodyCalkowania.Prostokatow:
                                for (int i = 0; i < n; i++)
                                {
                                    x += dx;
                                    suma += x * x * x * (x + 1) + 2;
                                }
                                suma *= dx;
                                break;

                            case MetodyCalkowania.Trapezow:
                                for (int i = 0; i < n; i++)
                                {
                                    x += dx;
                                    suma += x * x * x * (x + 1) + 2;
                                }
                                suma += (a * a * a * (a + 1) + b * b * b * (b + 1) + 4) / 2;
                                suma *= dx;
                                break;
                            default:
                                break;
                        }
                        Console.Write("Przybliżona wartość całki funkcji f(x) \nw przedziale <{0}; {1}> wynosi: {2}", a, b, suma);
                        Console.ReadKey(true);
                        break;
                }
            } while (!(c == 'K' || c == 'k'));

        }
    }
}

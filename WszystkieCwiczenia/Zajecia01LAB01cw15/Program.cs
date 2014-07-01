using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region wprowadzenie
            //Napisz program, który sortuje tablicę metodą przez wybieranie. Tablicę zainicjalizuj liczbami 
            //pseudolosowymi, korzystając z generatora liczb pseudolosowych: 
            //Random r = new Random();  //utworzenie obiektu  
            //      //generatora liczb pseudolosowych 
            //double n = r.NextDouble();    //losowanie liczby 
            //      //rzeczywistej z przedziału <0;1> 
            //W metodzie sortowania przez wybieranie (selection sort) wybieramy najmniejszy element tablicy i 
            //zamieniamy go z pierwszym elementem. Powyższą operację potarzamy, nie uwzględniając 
            //pierwszego elementu tablicy Czynność powtarzamy zmniejszając liczbę elementów z których 
            //wybieramy najmniejszy oraz zwiększając indeks elementu do zamiany. Czynność kończymy, gdy do 
            //wybrania pozostaje pojedynczy element.  
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
            //           Wybierz najmniejszy element tablicy i zamień go z pierwszym. Następnie powtarzaj operację 
            //pozostałymi elementami, aż pozostanie tylko jeden element - największy. 

            int min;
            double x;
            for (int i = 0; i < tablica.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < tablica.Length; j++)
                {
                    if (tablica[j] < tablica[min])
                    {
                        min = j;
                    }
                    if (min != i)
                    {
                        x = tablica[i];
                        tablica[i] = tablica[min];
                        tablica[min] = x;
                    }
                }
            }
            Console.WriteLine("\n\nElementy tablicy po sortowaniu: ");
            foreach (double i in tablica)
            {
                Console.Write("{0:f3}; ", i);
            }
            Console.ReadKey();
        }
    }
}

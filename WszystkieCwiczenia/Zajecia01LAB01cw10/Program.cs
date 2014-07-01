using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który znajduje największy i najmniejszy element tablicy. Tablicę zainicjalizuj liczbami 
            //pseudolosowymi, korzystając z generatora liczb pseudolosowych: 
            //Random r = new Random();  //utworzenie obiektu  
            //      //generatora liczb pseudolosowych 
            //int n = r.Next(0,101);    //losowanie liczby z  
            //      //przedziału <0;100> 

            int[] tablica = new int[15];
            Random generator = new Random();
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = generator.Next(0, 101);
            }
            Console.WriteLine("Wylosowano następujące wartości: ");
            foreach (int ii in tablica)
            {
                Console.Write("{0}, ", ii);

            }

            int indexMax = 0;
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[indexMax] < tablica[i])
                {
                    if (tablica[indexMax] < tablica[i])
                    {
                        indexMax = i;
                    }
                }
            }
            int indexMin = 0;
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[indexMin] > tablica[i])
                {
                    indexMin = i;
                }
                if (tablica[indexMax] < tablica[i])
                {
                    indexMax = i;
                }
            }
            Console.WriteLine("\n\nElement najmniejszy o indeksie {0} posiada wartość {1}.", indexMin, tablica[indexMin]);
            Console.WriteLine("Element najwiekszy o indeksie {0} posiada wartość {1}", indexMax, tablica[indexMax]);
            Console.ReadKey();
        }

    }
}


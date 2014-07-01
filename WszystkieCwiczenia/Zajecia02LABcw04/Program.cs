using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Napisz bibliotekę dll, która zawiera metodę sortującą tablicę liczb całkowitych. Sortowanie ma się ma 
//odbywać algorytmem zwanym sortowaniem szybkim (quick sort). W sortowaniu szybkim wybieramy 
//pewną wartość x, która dzieli nam tablicę na dwie części a[0], a[1]...a[q] oraz a[q+1]...a[n-1] i jest 
//spełniony warunek: 
//q j dla x j a
//q i dla x i a

//Następnie każdą z podtablic dzielimy na dwie części w podobny sposób, jak poprzednio z tym, że 
//dobieramy inny wartości x dzielącej podtablice. Dzielenie kończymy, gdy podtablica zwiera tylko 
//jednakowe wartości. Algorytm sortowanie szybkie jest przykładem strategii "dziel i rządź".  

//7.  Do rozwiązania dodaj nowy projekt, który przetestuje napisaną metodę sortującą 
//a.  Z menu File wybierz Add/New Project... 
//b.  W oknie dialogowym Add New Project określ następujące właściwości: 
//i.  typu projektu: Visual C#/Windows  
//ii.  szablon: Console Application  
//iii.  nazwa projektu: TestSortowania. 
//c.  Uczyń nowo utworzony projekt projektem startowym 
//d.  Podłącz do programu TestSortowania, podzespół Sortowanie. 
//i.  W okienku Solution Explorer, z menu kontekstowego związanego z elementem 
//reprezentującym projekt TestSortowania wybierz Add Reference... 
//ii.  W okienku Add Reference przejdź do zakładki Projects, zaznacz projekt Sortowanie i 
//naciśnij OK. 
//e.  Zaznacz, że będziemy korzystać z przestrzeni nazw Sortowanie.  

//using Sortowanie; 
//f.  Do metody Main dodaj kod testujący metodę Sortuj: 

//NIE JEST MOŻLIWE WYKONANIE POWYŻSZEGO, GDYŻ PROGRAM TEN MI NIE DZIAŁA!!!



namespace Cwiczenie04_TestSortowania
{
    class Program
    {
        static void Main(string[] args)
        {
            #region nie będzie działać, bo odwołuje się do wcześniejszego ćwiczenia!!!

            int[] liczby = new int[10];
            Random r = new Random();
            Console.WriteLine("Tablica przed sortowaniem:");
            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = r.Next(0, 1001);
                Console.Write("{0}, ", liczby[i]);
            }
            QuickSort.Sortuj(liczby);
            Console.WriteLine("\n\nTablica po sortowaniu:");
            foreach (int i in liczby)
                Console.Write("{0}, ", i);
            Console.ReadKey();

            #endregion
        }
    }
}

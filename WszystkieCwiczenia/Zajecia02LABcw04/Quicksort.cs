using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie04_TestSortowania
{
    class Quicksort
    {
        public static void Sortuj(int[] tab, int lewy, int prawy)
        {
            int i = lewy, j = prawy;
            int x, tmp;
            x = tab[(lewy + prawy) / 2];
            while (i <= j)
            {
                while (tab[i] < x)
                    i++;
                while (x < tab[j])
                    j--;
                if (i <= j)
                {
                    tmp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = tmp;
                    i++;
                    j--;
                }
                else break;
            }
            if (lewy < j) Sortuj(tab, lewy, j);
            if (i < prawy) Sortuj(tab, i, prawy);
        }

        public static void Sortuj(int[] tab)
        {
            Sortuj(tab, 0, tab.Length - 1);
        }
    }
}

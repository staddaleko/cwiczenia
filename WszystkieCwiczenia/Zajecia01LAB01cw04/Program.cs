using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie04
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Policzmy skomplikowane wyrażenie - \nw zalezności od wielkości z, będą różne wyniki. :)\nWpisz ujemne wartości, to je pomnozymy.\nWpisz zerowe, to coś tam dopasujemy i tak. \nWpisz dodatnie, to je dodamy :D");

            Console.WriteLine("\nPodaj wartość zmiennej x:\t ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wartość zmiennej y:\t ");
            y = Convert.ToDouble(Console.ReadLine());
            if (x < 0 && y < 0)
            {
                z = x * y;
            }
            else
            {
                if (x == 0 || y == 0)
                {
                    z = 10;
                }
                else
                {
                    z = x + y;
                }
            }

            Console.Write("z={0}", z);
            Console.ReadKey();
        }
    }
}

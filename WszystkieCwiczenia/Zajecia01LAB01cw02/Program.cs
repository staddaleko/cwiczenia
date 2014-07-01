using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie02
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, v;
            Console.WriteLine("Podaj wartość zmiennej x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wartość zmiennej y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wartość zmiennej z: ");
            z = Convert.ToDouble(Console.ReadLine());

            v = (4 * x - y) / (3 * (z * z + 1));

            Console.WriteLine("wartość wyrażenia v = (4 * x - y) / (3 * (z * z + 1)) wynosi: \n{0}.", v);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia01LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, tmp;
            int c, d;
            Console.Write("Podaj wartość zmiennej a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej b: ");
            b = Convert.ToDouble(Console.ReadLine());
            tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine("a={0}, b={1}", a, b);
            Console.ReadKey();
            c = Convert.ToInt32(a) - 15; d = Convert.ToInt32(b) + 20;
            c ^= d;
            d ^= c;
            c ^= d; //działa drugi sposób zamiany wartości, ale tylko całkowitych liczb
            Console.WriteLine("c={0}, d={1}", c, d);
            Console.ReadKey();

        }
    }
}

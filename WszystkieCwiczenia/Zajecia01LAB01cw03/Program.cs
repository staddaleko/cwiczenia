using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie03
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;

            try
            {
                Console.WriteLine("Policzmy równanie kwadratowe!");
                Console.Write("Podaj wartość parametru a: ");
                a = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                {
                    throw new Exception("Parametr 'a' powinien być różny od zera");
                }
                Console.Write("Podaj wartość parametru b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj wartość parametru c: ");
                c = Convert.ToDouble(Console.ReadLine());
                delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Równanie ma dwa pierwiastki: ");
                    Console.WriteLine("\tx1={0}", x1);
                    Console.WriteLine("\tx2={0}", x2);
                }
                else
                {
                    if (delta == 0)
                    {
                        x1 = -b / (2 * a);
                        Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty: ");
                        Console.WriteLine("\tx1={0}", x1);
                    }
                    else
                    {
                        Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Program został przerwany. {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}

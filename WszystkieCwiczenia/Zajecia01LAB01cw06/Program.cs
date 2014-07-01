using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie06
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Utwórz programu, który oblicza przybliżoną wartość pierwiastka kwadratowego, dla dowolnie wybranej 
            //liczby nieujemnej. Program będzie działał według poniższego schematu blokowego 

            Console.WriteLine("obliczmy przybliżoną wartość pierwiastka kwadratowego \nz podanej przez ciebie liczby!");
            const double epsilon = 0.00001;
            double a, x = 1, roznica;
            Console.WriteLine("podaj wartość zmiennej a: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a < 0)
            {
                throw new Exception("'a' nie może być ujemne...");
            }
            //Póki odległość między x2 i a jest większa od epsilon, do zmiennej x podstawiaj wartość 
            //wyrażenia:  
            while (Math.Abs(x * x - a) > epsilon)
            {
                x = (x + a / x) / 2;
            }
            Console.WriteLine("Wartością przybliżoną pierwiastka kwadratowego liczby {0} jest \n{1}.", a, x);
            Console.ReadKey();

        }
    }
}

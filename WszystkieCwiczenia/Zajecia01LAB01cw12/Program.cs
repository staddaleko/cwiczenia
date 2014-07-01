using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, które losuje sześć różnych liczb całkowitych z przedziału <1;49>. 
            byte[] numery = new byte[6];

            Random generator = new Random();
            int index = 0; //ile wylosowano liczb
            int i;
            bool flaga;
            do
            {
                numery[index] = (byte)generator.Next(1, 50);
                flaga = true;
                for (int ii = 0; ii < index; ii++)
                {
                    if (numery[index] == numery[ii])
                    {
                        flaga = false;
                        break;
                    }
                }
                if (flaga)
                {
                    index++;
                }
            } while (index < 6);

            Console.WriteLine("Wylosowane liczby to: ");
            foreach (int numer in numery)
            {
                Console.Write("{0}, ", numer);
            }
            Console.ReadKey();
        }
    }
}

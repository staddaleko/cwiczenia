using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia03LABcw01
{
    class OsobaDlakonsoli
    {
        public OsobaDlaKonsoli() 
        { 
            Console.Write("Podaj imię: ");  
            string imie = Console.ReadLine(); 
            Console.Write("Podaj nazwisko: "); 
            string nazwisko = Console.ReadLine();  
            int numerEwidencyjny; 
            do 
            {  
                Console.Write("Podaj numer ewidencyjny: ");  
            }  
            while (!int.TryParse(Console.ReadLine(), out numerEwidencyjny)); 
            int rokUrodzenia; 
            do
            { 
                Console.Write("Podaj rok urodzenia: ");  
            }  
            while (!int.TryParse(Console.ReadLine(), out rokUrodzenia)); 
            Console.WriteLine("Podaj adres zamieszkania:"); 
            AdresDlaKonsoli adr = new AdresDlaKonsoli(); 
            this.Osoba = new Osoba(numerEwidencyjny, rokUrodzenia, imie,     nazwisko, adr.Adres); 
        }  

        public OsobaDlaKonsoli(Osoba osoba)
        {  
             this.Osoba = osoba; 
        }
        OsobaDlaKonsoli os1 = new OsobaDlaKonsoli(); 
        Console.WriteLine(); 
        os1.ZmienAdres(); 
        Console.WriteLine(); 
        os1.ZmienNazwisko(); 
        Console.WriteLine("\n***************\n"); 
        os1.WypiszOsobe(); 
        Console.WriteLine("\n***************\n");
        Osoba osoba2 = new Osoba(123, 1990, "Anna", "Kowalska", 12, 23,      "Kwiatowa", "97-350", "Piotrków Tryb."); 
        os1.Osoba = osoba2; 
        os1.ZmienAdres(); 
        Console.WriteLine();  
        os1.ZmienNazwisko(); 
        Console.WriteLine("\n***************\n"); 
        os1.WypiszOsobe(); 
        Console.ReadKey();
    }
}

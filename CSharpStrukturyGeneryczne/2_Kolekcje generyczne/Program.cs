using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Kolekcje_generyczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Pracownik> Kolejka = new Queue<Pracownik>(); // FIFO = first in first out;
            Kolejka.Enqueue(new Pracownik { imie = "Marcin", nazwisko = "Nowak" });
            Kolejka.Enqueue(new Pracownik { imie = "Tomek", nazwisko = "Nowak" });
            Kolejka.Enqueue(new Pracownik { imie = "Jacek", nazwisko = "Zajac" });
            Kolejka.Enqueue(new Pracownik { imie = "Ola", nazwisko = "Kaczor" });


            while (Kolejka.Count > 0)
            {
               var pracownik = Kolejka.Dequeue();
                Console.WriteLine(pracownik.imie + " " + pracownik.nazwisko);
            }






        }

    }
}

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
            // Kolejka();
            //  Stos();
           // HashSet();



        }

        private static void  HashSet()
        {

            // HashSet - zbiór unikalnych przedmiotów nie pozwala przechowywać w kolekcji duplikatów
            // Nie wiemy jaka jest kolejność przechowywania elementów. Może się to zmieniać 
            HashSet<Pracownik> set = new HashSet<Pracownik>();
            var pracownik = new Pracownik { imie = "Marcin" };

            set.Add(pracownik);
            set.Add(pracownik);
            foreach (var item in set)
            {
                Console.WriteLine(item.imie);
            }
        }

        private static void Stos()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>(); // LIFO = Last In Last Out
            stos.Push(new Pracownik { imie = "Marcin", nazwisko = "Nowak" });
            stos.Push(new Pracownik { imie = "Tomek", nazwisko = "Nowak" });
            stos.Push(new Pracownik { imie = "Jacek", nazwisko = "Zajac" });
            stos.Push(new Pracownik { imie = "Ola", nazwisko = "Kaczor" });
            Console.WriteLine();
            Console.WriteLine("Stos");

            while (stos.Count > 0)
            {
                var pracownik = stos.Pop(); // zwraca element ze stosu i go usuwa
                Console.WriteLine(pracownik.imie + " " + pracownik.nazwisko);
            }
        }

        private static void Kolejka()
        {
            Queue<Pracownik> Kolejka = new Queue<Pracownik>(); // FIFO = first in first out;
            Kolejka.Enqueue(new Pracownik { imie = "Marcin", nazwisko = "Nowak" });
            Kolejka.Enqueue(new Pracownik { imie = "Tomek", nazwisko = "Nowak" });
            Kolejka.Enqueue(new Pracownik { imie = "Jacek", nazwisko = "Zajac" });
            Kolejka.Enqueue(new Pracownik { imie = "Ola", nazwisko = "Kaczor" });

            Console.WriteLine("Kolejka");

            while (Kolejka.Count > 0)
            {
                var pracownik = Kolejka.Dequeue(); // zwraca element z kolejki i go usuwa
                Console.WriteLine(pracownik.imie + " " + pracownik.nazwisko);
            }
        }
    }
}

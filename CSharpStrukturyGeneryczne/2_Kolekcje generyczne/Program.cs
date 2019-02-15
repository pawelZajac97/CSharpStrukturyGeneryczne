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
            //LinkedList();
            //LinkedList2();
        }

        private static void LinkedList2()
        {
            LinkedList<int> lista = new LinkedList<int>(); // Lista w której elementy zawierają wskaźnik do poprzedniego i następnego elementu
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);
            var elementPierwszy = lista.First; // Odnieśienie do pierwszego elementu listy. Typ LinkedListNode
            var elementOstatni = lista.Last;
            lista.AddAfter(elementPierwszy, 10);
            lista.AddBefore(elementPierwszy, 20);

            var wezel = lista.First;
            while (wezel != null) // null gdy wyświetlimy wszystkie elementy;
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void LinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6); // liczba 6 bedzie dodana przed liczbe 5
            lista.AddFirst(7); // liczba -""-
            lista.AddLast(1);
            lista.AddLast(2);


            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
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

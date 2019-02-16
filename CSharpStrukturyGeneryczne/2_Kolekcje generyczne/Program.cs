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
            //Kolejka();
            //Stos();
            //HashSet();
            //LinkedList();
            //LinkedList2();
            //Dictonary();
            //DictonaryAdvanced();
            //SortedDictionary();
            //SortedList();
            //SortedHash();
            var pracownicy = new DziałyKolekcja();

           

            pracownicy.Add("Ksiegowosc",new Pracownik { nazwisko = "Nowak" })
                      .Add("Ksiegowosc",new Pracownik { nazwisko = "Kowal" })
                      .Add("Ksiegowosc",new Pracownik { nazwisko = "Kaczor" })
                      .Add("Ksiegowosc",new Pracownik { nazwisko = "Bogacki" })
                      .Add("Ksiegowosc", new Pracownik { nazwisko = "Nowak" });

            

            pracownicy.Add("Sprzedaż",new Pracownik { nazwisko = "Nowak" })
                      .Add("Sprzedaż",new Pracownik { nazwisko = "Głowacki" })
                      .Add("Sprzedaż",new Pracownik { nazwisko = "Czapla" })
                      .Add("Sprzedaż",new Pracownik { nazwisko = "Nowak" });

            foreach (var item in pracownicy) // literuje po kluczu
            {
                Console.WriteLine(item.Key);
                foreach (var pracownik in item.Value) // literuje po wartościach danego klucza
                {
                    Console.WriteLine("\t" + pracownik.nazwisko);
                }
            }







        }

        private static void SortedHash()
        {
            var set = new SortedSet<int>();
            set.Add(8);
            set.Add(6);
            set.Add(5);
            set.Add(3);
            set.Add(2);
            set.Add(1);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            var set2 = new SortedSet<string>();
            set2.Add("tomek");
            set2.Add("iza");
            set2.Add("ola");
            set2.Add("ala");
            set2.Add("piotr");
            set2.Add("beata");

            foreach (var item in set2)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedList()
        {
            var listaPosortowana = new SortedList<int, string>(); // bardziej zooptymalizowanie niż SortedDictronary. Jak najszybsza iteracja(po wszystkich elementach).

            listaPosortowana.Add(3, "trzy");
            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(4, "cztery");
            listaPosortowana.Add(2, "dwa");

            foreach (var item in listaPosortowana)
            {
                Console.WriteLine(item.Value);
            }
        }

        private static void SortedDictionary()
        {
            var pracownicy = new SortedDictionary<string, List<Pracownik>>(); // sortuje po kluczu. Lepsza do wyszuiwania elementów po określonym kluczu niż Sorted List. Jednak więcej zużywa pamięci.
            pracownicy.Add("Sprzedaż", new List<Pracownik> { new Pracownik { imie = "Jan", nazwisko = "Kowal"},
                                                             new Pracownik { imie="Tomek" , nazwisko ="Nowak"},
                                                             new Pracownik { imie = "Marcin", nazwisko = "Bien"} });
            pracownicy.Add("Informatyka", new List<Pracownik> { new Pracownik { imie = "Marcin", nazwisko = "Kowal"},
                                                                new Pracownik { imie = "Tomek", nazwisko ="Wrobel"} });
            pracownicy.Add("Ksiegowosc", new List<Pracownik> {  new Pracownik { imie = "Olek", nazwisko = "Kowalski"},
                                                                new Pracownik { imie = "Bartek", nazwisko ="Nawrocko"},
                                                                new Pracownik { imie = "Jurek", nazwisko = "Pytel"},
                                                                new Pracownik { imie = "Robert", nazwisko ="Stach"}});

            foreach (var item in pracownicy)
            {
                Console.WriteLine($"Ilosc pracownikow w dziale {item.Key} wynosi {item.Value.Count}");
            }
        }

        private static void DictonaryAdvanced()
        {
            var pracownicy = new Dictionary<string, List<Pracownik>>(); // nie wolno dodawać duplikatu klucza

            pracownicy.Add("Ksiegowosc", new List<Pracownik>() { new Pracownik { nazwisko = "Nowak" },
                                                                 new Pracownik {nazwisko ="Kowal"},
                                                                 new Pracownik { nazwisko = "Kaczor" } });

            pracownicy["Ksiegowosc"].Add(new Pracownik { nazwisko = "Nowak" });

            pracownicy.Add("Informatyka", new List<Pracownik>() { new Pracownik {nazwisko = "Kowalski" },
                                                                  new Pracownik { nazwisko = "Bogacki" } });

            foreach (var item in pracownicy)
            {
                Console.WriteLine("Dział :" + item.Key);

                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.nazwisko);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pracownicy z ksiegowosci");

            foreach (var item in pracownicy["Ksiegowosc"])
            {
                Console.WriteLine(item.nazwisko);
            }
        }

        private static void Dictonary()
        {
            var pracownicy = new Dictionary<string, Pracownik>(); // nie wolno dodawać duplikatu klucza

            pracownicy.Add("Nowak", new Pracownik { nazwisko = "Nowak" });
            pracownicy.Add("Kowal", new Pracownik { nazwisko = "Kowal" });
            pracownicy.Add("Kaczor", new Pracownik { nazwisko = "Kaczor" });



            var kowal = pracownicy["Kowal"];

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine($"{pracownik.Key}:{pracownik.Value.nazwisko}");
            }
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

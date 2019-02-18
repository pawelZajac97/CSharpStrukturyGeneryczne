using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        static void KonsolaWypisz (double dane)
        {
            Console.WriteLine(dane);
        }
        static void Main(string[] args)
        {
            
            var kolejka = new KolejkaKolowa<double>(pojemnosc:3);
            kolejka.elementUsunięty += Kolejka_elementUsunięty;



            WprowadzanieDanych(kolejka);
            kolejka.Drukuj(d => Console.WriteLine(d)); // przekazanie delegata za pomocą wyrażenia lambda
            PrzetwarzanieDanych(kolejka);
        }

        private static void Kolejka_elementUsunięty(object sender, ElementUsunietyEventArgs<double> e)
        {
            Console.WriteLine($"Kolejka jest pełna. Element usunięty to : {e.ElementUsuniety}. Nowy element to {e.ElementNowy}");
        }

        private static void PrzetwarzanieDanych(IKolejka<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine($"W naszej kolejce jest : ");


            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }
            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscWejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }
}

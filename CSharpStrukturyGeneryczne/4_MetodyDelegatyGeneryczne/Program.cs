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
            Action<double> drukuj = d => Console.WriteLine(d);// delegat generyczny który zwraca void. "d" to parametr nie trzeba podawać typu kompilator sam się domyśli

            Func<double, double> potegowanie = d => d * d; // delegat generyczny który zwraca wartość.
            Func<double, double, double> dodaj = (x, y) => x + y;
            drukuj((dodaj(potegowanie(3),4)));
            




            var kolejka = new KolejkaKolowa<double>();
            WprowadzanieDanych(kolejka);
            kolejka.Drukuj(d => Console.WriteLine(d)); // przekazanie delegata za pomocą wyrażenia lambda
            PrzetwarzanieDanych(kolejka);
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

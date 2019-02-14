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
            var liczby = new List<int>(10); // gdy zostanie przekroczona pojemnosc zostaje podwojona
            var pojemnosc = -1;
            while (pojemnosc < 19)
            {
                if (liczby.Capacity != pojemnosc)
                {
                    pojemnosc = liczby.Capacity;
                    Console.WriteLine(pojemnosc);
                    pojemnosc++;
                }
                liczby.Add(1);
            }

           


        }

    }
}

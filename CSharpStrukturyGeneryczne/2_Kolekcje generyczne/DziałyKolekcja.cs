using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Kolekcje_generyczne
{
    public class DziałyKolekcja: SortedDictionary<string,SortedSet<Pracownik>>
    {
        public DziałyKolekcja Add(string nazwaDziału, Pracownik pracownik)
        {
            if (!ContainsKey(nazwaDziału))
            {
                Add(nazwaDziału, new SortedSet<Pracownik>(new PracownikComparer()));
                
            }
            this[nazwaDziału].Add(pracownik);
            return this;
        }



    }
}

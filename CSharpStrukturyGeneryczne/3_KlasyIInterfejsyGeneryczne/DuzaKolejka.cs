﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace _3_KlasyIInterfejsyGeneryczne
{
    public class DuzaKolejka<T> : IKolejka<T>
    {
        protected Queue<T> kolejka = new Queue<T>();

        public DuzaKolejka()
        {
            Queue<T> kolejka = new Queue<T>();
        }

        public virtual bool JestPelny => throw new System.NotImplementedException();

        public virtual bool JestPusty
        {
            get
            {
                return kolejka.Count == 0;
            }
        }

        public virtual T Czytaj()
        {
            return kolejka.Dequeue();
        }

        public virtual void Zapisz(T wartosc)
        {
            kolejka.Enqueue(wartosc);
        }

        public IEnumerable<Twyjscie> ElementJako<Twyjscie>()
        {
            var konwerter = TypeDescriptor.GetConverter(typeof(T));

            foreach(var item in kolejka)
            {
                var wynik = konwerter.ConvertTo(item, typeof(Twyjscie));
                yield return (Twyjscie)wynik;
            }
        }

        public IEnumerator<T> GetEnumerator() // pozwala robic iteracje po kolekcji
        {
            //return kolejka.GetEnumerator();
            foreach (var item in kolejka)
            {
                // filtrowanie
                yield return item; // Z enumaratora będą zwraca wartości pojedynczo
            }
        }

        IEnumerator IEnumerable.GetEnumerator() // zwraca GetEnumerator który pozwala użyć go w metodzie wyżej GetEnumaerator();
        {
            return GetEnumerator();
           
        }

    
    }
}
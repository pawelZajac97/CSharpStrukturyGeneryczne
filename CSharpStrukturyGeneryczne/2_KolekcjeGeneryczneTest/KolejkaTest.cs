using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczneTest
{
    [TestClass]
    public class KolejkaTest
    {
        [TestMethod]
        public void UzycPeek()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);
            Assert.AreEqual(1, kolejka.Peek()); // metoda peek podgląda element i nie usuwa go;
        }
        [TestMethod]
        public void UzycContains()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);
            Assert.IsTrue(kolejka.Contains(3));
        }

        [TestMethod]
        public void UzycToArray()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1); // dodaje elementy do kolejki
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);
            var tablica = kolejka.ToArray(); // kopiuje wartości kolejki do tablicy
            kolejka.Dequeue();
            Assert.AreEqual(1, tablica[0]);
            Assert.AreEqual(3, kolejka.Count);
        }

        [TestMethod]
        public void UzycClear()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);
            kolejka.Clear(); // usuwa szystkie lementy w kolejce
            Assert.AreEqual(0, kolejka.Count);
        }
    }
}

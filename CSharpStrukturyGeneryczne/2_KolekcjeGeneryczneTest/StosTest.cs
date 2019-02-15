using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTest
{
    [TestClass]
    public class StosTest
    {
        [TestMethod]
        public void UzycPeek()
        {
            var stos = new Stack<int>();
            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);
            Assert.AreEqual(4, stos.Peek()); // metoda peek podgląda element i nie usuwa go;
        }
        [TestMethod]
        public void UzycContains()
        {
            var stos = new Stack<int>();
            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);
            Assert.IsTrue(stos.Contains(3));
        }

        [TestMethod]
        public void UzycToArray()
        {
            var stos = new Stack<int>();
            stos.Push(1); // dodaje elementy do kolejki
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);
            var tablica = stos.ToArray(); // kopiuje wartości kolejki do tablicy
            stos.Pop();
            Assert.AreEqual(4, tablica[0]);
            Assert.AreEqual(3, stos.Count);
        }

        [TestMethod]
        public void UzycClear()
        {
            var stos = new Stack<int>();
            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);
            stos.Clear(); // usuwa szystkie lementy w kolejce
            Assert.AreEqual(0, stos.Count);
        }
    }
}

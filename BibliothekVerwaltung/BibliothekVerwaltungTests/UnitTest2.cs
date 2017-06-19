using System;
using BibliothekVerwaltung;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BibliothekVerwaltungTests
{
    [TestClass]
    public class UnitTest2
    {
        List<string> list = new List<string>();
        [TestMethod]
        public void NameHinzufuegenTest()
        {
            Bibliothek bn = new Bibliothek();
            bn.NameHinzufuegen("Sand");
            Assert.AreEqual(1,bn.Liste.Count);

        }
        [TestMethod]
        public void NameEntfernenTest()
        {
            Bibliothek bn = new Bibliothek();
            list.Add("Sand");
            bn.NameEntfernen("Sand");
            Assert.AreEqual(0, bn.Liste.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NameEntfernenNotNull()
        {
            Bibliothek bn = new Bibliothek();
            list.Add("Sand");
            bn.NameEntfernen(null);
            Assert.AreEqual(null,bn.Liste[0]);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NameEntfernenNichtLeer()
        {
            Bibliothek bn = new Bibliothek();
            list.Add("Sand");
            bn.NameEntfernen("");
            Assert.AreEqual("Sand",bn.Liste[0]);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NameHinzufuegenNichtLeer()
        {
            Bibliothek bn = new Bibliothek();
            bn.NameHinzufuegen("");
            Assert.AreEqual(0, bn.Liste.Count);
        }
        public void NameHinzufuegenNotNull()
        {
            Bibliothek bn = new Bibliothek();
            list.Add("Sand");
            bn.NameHinzufuegen(null);
            Assert.AreEqual(null,bn.Liste[0];
        }
    }
}

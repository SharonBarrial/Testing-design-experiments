using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListasTipoCola1;
using System;

namespace PruebasUnitariasColas
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        public void PruebaUnitaria1()
        {
            Cola cola1 = new Cola();
            cola1.Insertar(0);
            cola1.Insertar(8);
            cola1.Insertar(9);

            Assert.IsFalse(cola1.Vacia());
            int extracted = cola1.Extraer();
            Assert.AreEqual(0, extracted, "Se extrajo el 0");
            extracted = cola1.Extraer();
            Assert.AreEqual(8, extracted, "Se extrajo el 8");
            extracted = cola1.Extraer();
            Assert.AreEqual(9, extracted, "Se extrajo el 9");

            Assert.IsTrue(cola1.Vacia(), "La cola esta vacia");
        }

        [TestMethod]
        public void PruebaUnitaria2()
        {
            Cola cola1 = new Cola();
            int extracted = cola1.Extraer();

            Assert.AreEqual(int.MaxValue, extracted);
            Assert.IsTrue(cola1.Vacia());
        }

        [TestMethod]
        public void PruebaUnitaria3()
        {
            Cola cola1 = new Cola();

            cola1.Insertar(1);
            cola1.Insertar(2);
            cola1.Insertar(3);

            Assert.IsFalse(cola1.Vacia());
        }

        [TestMethod]
        public void PruebaUnitaria4()
        {
            Cola cola = new Cola();
            cola.Insertar(7);

            int extracted = cola.Extraer();

            Assert.AreEqual(7, extracted);
            Assert.IsTrue(cola.Vacia());
        }
        [TestMethod]
        public void PruebaUnitaria5()
        {
            Cola cola = new Cola();

            Assert.IsTrue(cola.Vacia(), "Newly created queue should be empty");
        }


    }
}
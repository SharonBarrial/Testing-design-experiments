using jetsmart;
using System;
using System.Drawing;

namespace EA1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int numeroBoleto = 600;
            string nombrePasajero = "Juan Pérez";
            string destino = "Lima";
            string fechaSalida = "2023-10-02";
            string horaSalida = "10:00";

            // Act
            ReemisionBoleto reemision = new ReemisionBoleto(numeroBoleto, nombrePasajero, destino, fechaSalida, horaSalida);

            // Assert
            Assert.AreEqual(numeroBoleto, reemision.NumeroBoleto);
            Assert.AreEqual(nombrePasajero, reemision.NombrePasajero);
            Assert.AreEqual(destino, reemision.Destino);
            Assert.AreEqual(fechaSalida, reemision.FechaSalida);
            Assert.AreEqual(horaSalida, reemision.HoraSalida);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string fechaSalida = "2023-10-02";

            // Act
            ReemisionBoleto reemision = new ReemisionBoleto(100, "Juan Pérez", "Lima", fechaSalida, "10:00");

            // Assert
            DateTime fecha = DateTime.Parse(fechaSalida);
            Assert.IsTrue(fecha >= DateTime.Today);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            string fechaSalida = "2023-10-02";

            // Act
            ReemisionBoleto reemision = new ReemisionBoleto(100, "Juan Pérez", "Lima", fechaSalida, "10:00");

            // Assert
            DateTime fecha = DateTime.Parse(fechaSalida);
            Assert.IsTrue(fecha >= DateTime.Today);
        }
    }
}


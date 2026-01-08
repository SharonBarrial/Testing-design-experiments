using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class Test_CalculadoraEjemplo
    {
        [TestMethod]
        public void Test_Suma_correcta()
        {
            //Arrange: inicializar las variables
            int sumando1 = 2;
            int sumando2 = 5;
            int sumando3 = -3;
            int sumando4 = -7;
            int sumando5 = 1;

            //Act: ejecutamos el metodo a testear
            int prueba1 = CalculadoraEjemplo.Suma(sumando1, sumando2);
            int prueba2 = CalculadoraEjemplo.Suma(sumando3, sumando2);
            //int prueba3 = CalculadoraEjemplo.Suma(sumando5, sumando2, sumando1);
            int prueba4 = CalculadoraEjemplo.Suma(sumando3, sumando4);
           // int prueba5 = CalculadoraEjemplo.Suma(sumando3, sumando4, sumando1, sumando2);

            //Assert: comprobacion de los valores
            Assert.AreEqual(25, prueba1);
            Assert.AreEqual(4, prueba2);
            //Assert.AreEqual(7, prueba3);
            Assert.AreEqual(20, prueba4);            

        }
 

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void test_excepcion()
        {

            int dividendo = 120;
            int divisor = 0;
            double resultado = CalculadoraEjemplo.Division(dividendo, divisor);

        }


        [TestMethod]
        public void test_rest()
        {
            //Arrange
            int rest1 = 10;
            int rest2 = 15;

            //Act
            int result = CalculadoraEjemplo.Resta(rest1, rest2);

            //Assert
            //Assert.AreEqual(19, result);
            Assert.IsTrue(result == 8);

        }

    }
}
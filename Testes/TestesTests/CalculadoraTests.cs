using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Security.Principal;

namespace Testes.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        [TestMethod()]
        public void SomarTest()
        {
            var soma = Calculadora.Somar(10, 5);
            var expected = 15;

            Assert.AreEqual(expected, soma);

        }
        [TestMethod()]
        public void SomarPorNegativoTest()
        {
            var soma = Calculadora.Somar(10, -5);
            var expected = 5; 

            Assert.AreEqual(expected, soma);

        }

        [TestMethod()]
        public void SubtrairTest()
        {
            var subtracao = Calculadora.Subtrair(10, 5);
            var expected = 5;

            Assert.AreEqual(expected, subtracao);
        }

        [TestMethod()]
        public void SubtrairPorNegativoTest()
        {
            var subtracao = Calculadora.Subtrair(-10, -5);
            var expected = -5;

            Assert.AreEqual(expected, subtracao);
        }

        [TestMethod()]
        public void MultiplicarTest()
        {
            var mult = Calculadora.Multiplicar(10, 5);
            var expected = 50;

            Assert.AreEqual(expected, mult);
        }

        [TestMethod()]
        public void MultiplicarPorNegativoTest()
        {
            var mult = Calculadora.Multiplicar(-10, 5);
            var expected = -50;

            Assert.AreEqual(expected, mult);
        }

        [TestMethod()]
        public void DividirTest()
        {
            var divid = Calculadora.Dividir(10, 5);
            var expected = 2;

            Assert.AreEqual(expected, divid);
        }

        [TestMethod()]
        public void DividirPorNegativoTest()
        {
            var divid = Calculadora.Dividir(-10, 5);
            var expected = -2;

            Assert.AreEqual(expected, divid);
        }

        [TestMethod()]
        public void DividirPorZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Calculadora.Dividir(10.0, 0.0));
        }
    }
}
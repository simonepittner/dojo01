using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FIZZBUZZ;

namespace TESTE_FIZZBUZZ
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveRetornarFizz()
        {
            Program p = new Program();
            Assert.AreEqual("Fizz", p.RetornaFizz(2));
        }

        [TestMethod]
        public void NaoDeveRetornarFizz()
        {
            Program p = new Program();
            Assert.AreNotEqual("Fizz", p.RetornaBuzz(3));
        }

        [TestMethod]
        public void DeveRetornarBuzz()
        {
            Program p = new Program();
            Assert.AreEqual("Buzz", p.RetornaBuzz(3));
        }

        [TestMethod]
        public void NaoDeveRetornarBuzz()
        {
            Program p = new Program();
            Assert.AreNotEqual("Buzz", p.RetornaFizz(1));
        }

        [TestMethod]
        public void DeveRetornarFizzQuandoFor2()
        {
            Program p = new Program();
            Assert.AreEqual("Fizz", p.RetornaFizz(2));
        }

        [TestMethod]
        public void NaoDeveRetornarFizzQuandoNaoFor2()
        {
            Program p = new Program();
            Assert.AreNotEqual("Fizz", p.RetornaFizz(3));
        }

        [TestMethod]
        public void DeveRetornarBuzzQuandoFor3()
        {
            Program p = new Program();
            Assert.AreEqual("Buzz", p.RetornaBuzz(3));
        }

        [TestMethod]
        public void NaoDeveRetornarBuzzQuandoNaoFor3()
        {
            Program p = new Program();
            Assert.AreNotEqual("Buzz", p.RetornaBuzz(2));
        }

        [TestMethod]
        public void DeveRetornarFizzQuandoForNumeroPar()
        {
            Program p = new Program();
            Assert.AreEqual("Fizz", p.RetornarFizzBuzz(2));
        }
        
        [TestMethod]
        public void DeveRetornarBuzzQuandoForNumeroImpar()
        {
            Program p = new Program();
            Assert.AreEqual("Buzz", p.RetornarFizzBuzz(3));
        }

        [TestMethod]
        public void DeveRetornarErroQuandoNumeroMenorZero()
        {
            Program p = new Program();
            Assert.AreEqual("Erro", p.RetornarFizzBuzz(-1));
        }
    }
}

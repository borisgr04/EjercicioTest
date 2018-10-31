using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioTest;
namespace UnitTestProject1
{
    [TestClass]
    public class OperacionTest
    {
        [TestMethod]
        public void TestSumar()
        {
            Operacion operacion = new Operacion();
            var r=operacion.Sumar(1, 2);
            Assert.AreEqual(3, r);
        }
    }
}

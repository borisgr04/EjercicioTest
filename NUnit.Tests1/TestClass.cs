using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioTest;
namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {

        [SetUp]
        public void Setup()
        {
            TestContext.WriteLine("SeEjecuto una prueba ");
        }
        //AAA
        [Test]
        public void TestSumar()
        {
            //Arrange     == Dado
            Operacion operacion = new Operacion();
            //Act         == Cuando
            var r = operacion.Sumar(1, 2);
            //Asset       == Entonces 
            Assert.AreEqual(3, r);
            
        }

        //AAA
        [TestCase(5,2,7)]
        [TestCase(1,2,3)]
        [Test]
        public void TestSumar(int a, int b, int result)
        {
            //Arrange     == Dado
            Operacion operacion = new Operacion();
            //Act         == Cuando
            var r = operacion.Sumar(a, b);
            //Asset       == Entonces 
            Assert.AreEqual(result, r);
        }
    }
}

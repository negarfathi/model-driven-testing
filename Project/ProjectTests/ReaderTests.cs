using System;
using System.IO;
using NUnit.Framework;

namespace Project.Tests
{
    [TestFixture()]
    public class ReaderTests
    {
        [Test()]
        public void ReadOperand1Test()
        {
            var input = new StringReader("1");
            Console.SetIn(input);
            Reader reader = new Reader();
            double result = reader.ReadOperand1();
            Assert.AreEqual(1, result);
        }
        [Test()]
        public void ReadOperand2Test()
        {
            var input = new StringReader("2");
            Console.SetIn(input);
            Reader reader = new Reader();
            double result = reader.ReadOperand2();
            Assert.AreEqual(2, result);
        }
        [Test()]
        public void ReadOperatorTest()
        {
            var input = new StringReader("+");
            Console.SetIn(input);
            Reader reader = new Reader();
            string result = reader.ReadOperator();
            Assert.AreEqual("+", result);
        }
    }
}
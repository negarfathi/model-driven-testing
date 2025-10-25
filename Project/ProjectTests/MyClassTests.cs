using System;
using System.IO;
using NUnit.Framework;

namespace Project.Tests
{
    [TestFixture()]
    public class MyClassTests
    {
        [Test()]
        public void MyMethodTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);
            var input = new StringReader("0");
            Console.SetIn(input);
            ReaderStub readerStub = new ReaderStub();
            CalculatorStub calculatorStub = new CalculatorStub();
            MyClass myClass = new MyClass(readerStub, calculatorStub);
            myClass.MyMethod();
            Assert.That(output.ToString(), Is.EqualTo("Result: 3"));
        }
    }
}
using NUnit.Framework;

namespace Project.Tests
{
    [TestFixture()]
    public class CalculatorTests
    {
        [Test()]
        public void AdditionTest()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Addition(1, 2);
            Assert.AreEqual(3, result);
        }
        [Test()]
        public void SubtractionTest()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Subtraction(1, 2);
            Assert.AreEqual(-1, result);
        }
        [Test()]
        public void MultiplicationTest()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Multiplication(1, 2);
            Assert.AreEqual(2, result);
        }
        [Test()]
        public void DivisionTest()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Division(1, 2);
            Assert.AreEqual(0.5, result);
        }
    }
}
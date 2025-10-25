using System;

namespace Project
{
    public interface ICalculator
    {
        double Addition(double operand1, double operand2);
        double Subtraction(double operand1, double operand2);
        double Multiplication(double operand1, double operand2);
        double Division(double operand1, double operand2);
    }
    public class CalculatorStub : ICalculator
    {
        public double Addition(double operand1, double operand2)
        {
            return 3;
        }
        public double Subtraction(double operand1, double operand2)
        {
            return -1;
        }
        public double Multiplication(double operand1, double operand2)
        {
            return 2;
        }
        public double Division(double operand1, double operand2)
        {
            return 0.5;
        }
    }
    public class Calculator : ICalculator
    {
        public double Addition(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
        public double Subtraction(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
        public double Multiplication(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
        public double Division(double operand1, double operand2)
        {
            return operand1 / operand2;
        }
    }
}
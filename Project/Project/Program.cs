using System;

namespace Project
{
    public class MyClass
    {
        private IReader iReader;
        private ICalculator iCalculator;
        private static double operand1;
        private static double operand2;
        private static string Operator;
        private static double result;
        public MyClass(IReader iReader, ICalculator iCalculator)
        {
            this.iReader = iReader;
            this.iCalculator = iCalculator;
        }
        public void MyMethod()
        {
            operand1 = iReader.ReadOperand1();
            operand2 = iReader.ReadOperand2();
            Operator = iReader.ReadOperator();
            switch (Operator)
            {
                case "+":
                    result = iCalculator.Addition(operand1, operand2);
                    break;
                case "-":
                    result = iCalculator.Subtraction(operand1, operand2);
                    break;
                case "*":
                    result = iCalculator.Multiplication(operand1, operand2);
                    break;
                case "/":
                    result = iCalculator.Division(operand1, operand2);
                    break;
            }
            Console.Write("Result: " + result);
            Console.ReadLine();
        }
    }
    public class Program
    {
        public static void Main()
        {
            Reader reader = new Reader();
            Calculator calculator = new Calculator();
            MyClass myClass = new MyClass(reader, calculator);
            myClass.MyMethod();
        }
    }
}
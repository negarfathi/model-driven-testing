using System;

namespace Project
{
    public interface IReader
    {
        double ReadOperand1();
        double ReadOperand2();
        string ReadOperator();
    }
    public class ReaderStub : IReader
    {
        public double ReadOperand1()
        {
            return 1;
        }
        public double ReadOperand2()
        {
            return 2;
        }
        public string ReadOperator()
        {
            return "+";
        }
    }
    public class Reader : IReader
    {
        private double operand1;
        private double operand2;
        private string Operator;
        public double ReadOperand1()
        {
            Console.Write("Operand1: ");
            operand1 = double.Parse(Console.ReadLine());
            return operand1;
        }
        public double ReadOperand2()
        {
            Console.Write("Operand2: ");
            operand2 = double.Parse(Console.ReadLine());
            return operand2;
        }
        public string ReadOperator()
        {
            Console.Write("Operator: ");
            Operator = Console.ReadLine();
            return Operator;
        }
    }
}
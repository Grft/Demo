using System;

namespace Exercise2
{
    class Arithmetic
    {
        public double a, b;

        public double Addition()
        {
            return a + b;
        }

        public double Subtraction()
        {
            return a - b;
        }

        public double Multiplication()
        {
            return a * b;
        }

        public double Division()
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic A = new Arithmetic();
            char symbol;
            Console.Write("input double a: ");
            A.a = Convert.ToDouble(Console.ReadLine());
            Console.Write("input double b: ");
            A.b = Convert.ToDouble(Console.ReadLine());
            Console.Write("input ( + - * / ): ");
            symbol = Convert.ToChar(Console.ReadLine());
            switch(symbol)
            {
                case '+':
                    Console.WriteLine(A.Addition());
                    break;
                case '-':
                    Console.WriteLine(A.Subtraction());
                    break;
                case '*':
                    Console.WriteLine(A.Multiplication());
                    break;
                case '/':
                    Console.WriteLine(A.Division());
                    break;
                default:
                    Console.WriteLine("Wrong Symbel");
                    break;
            }
        }
    }
}

using System;

namespace OOP_on_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            char operation;

            Console.Write("Введите первое число: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Выберите операцию (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write($"\nРезультат: ");
            Math.Calculate(firstNumber, secondNumber, operation);

            Console.WriteLine("\nАнализ чисел: ");
            Math.Analyze(firstNumber, secondNumber);
        }
    }
}
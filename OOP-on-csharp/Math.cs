using System;

namespace OOP_on_csharp
{
    internal class Math
    {
        public static void Calculate(double firstNumber, double secondNumber, char operation)
        {
            double result;

            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                default:
                    Console.WriteLine("\nВы неверно ввели операцию");
                    return;
            }

            Console.WriteLine($"{result}");
        }

        public static void Analyze(double firstNumber, double secondNumber)
        {
            if (firstNumber % 2 == 0)
                Console.Write($"{firstNumber} - четное, ");
            else
                Console.Write($"{firstNumber} - нечетное, ");
            if (firstNumber >= 0)
                Console.WriteLine("положительное");
            else
                Console.WriteLine("отрицательное");

            if (secondNumber % 2 == 0)
                Console.Write($"{secondNumber} - четное, ");
            else
                Console.Write($"{secondNumber} - нечетное, ");
            if (secondNumber >= 0)
                Console.WriteLine("положительное");
            else
                Console.WriteLine("отрицательное");
        }
    }
}
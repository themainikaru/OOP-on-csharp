using System;

namespace OOP_on_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box1 = new Box<int>(888);
            Box<string> box2 = new Box<string>("string");

            Console.WriteLine($"число в коробке: {box1.Get()}");
            Console.WriteLine($"строка в коробке: {box2.Get()}");
        }
    }
}
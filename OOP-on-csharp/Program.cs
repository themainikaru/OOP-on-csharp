using System;

namespace OOP_on_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> int1 = new Box<int>(111);
            Box<int> int2 = new Box<int>(222);
            Box<string> str1 = new Box<string>("string1");
            Box<string> str2 = new Box<string>("string2");

            Console.WriteLine("before Swap()");
            Console.WriteLine($"a = {int1.Get()}\t\tb = {int2.Get()}");
            Console.WriteLine($"a = {str1.Get()}\tb = {str2.Get()}");

            Utils.Swap(ref int1, ref int2);
            Utils.Swap(ref str1, ref str2);

            Console.WriteLine("\nafter Swap()");
            Console.WriteLine($"a = {int1.Get()}\t\tb = {int2.Get()}");
            Console.WriteLine($"a = {str1.Get()}\tb = {str2.Get()}");


            Pair<int, string> pair = new Pair<int, string>(333, "string3");
            Console.WriteLine($"\nfirst item: {pair.GetFirstItem()}\tsecond item: {pair.GetSecondItem()}");
        }
    }
} 
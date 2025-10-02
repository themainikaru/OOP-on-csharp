using System;

namespace OOP_on_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Money amount0 = new Money(111, 222);
            Money amount1 = new Money(333, 444);

            Console.WriteLine(Money.Sum(amount0, amount1));
        }
    }

    public struct Money
    {
        public int Roubles;
        public int Kopecks;
        public Money(int roubles, int kopecks)
        {
            Roubles = roubles;
            Kopecks = kopecks;
        }

        public static string Sum(Money amount1, Money amount2)
        {
            long roubles = amount1.Roubles + amount2.Roubles;
            long kopecks = amount1.Kopecks + amount2.Kopecks;

            if (kopecks >= 100)
            {
                roubles += kopecks / 100;
                kopecks = kopecks % 100;
            }

            return $"{roubles} рублей {kopecks} копеек";
        }
    }
}
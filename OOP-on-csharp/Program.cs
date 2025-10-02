using System;

namespace OOP_on_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PositionVector vector0 = new PositionVector(10, 20);
            PositionVector vector1 = new PositionVector(30, 40);


            Console.WriteLine($"vector 1 length is {vector0.GetLength()}");
            Console.WriteLine($"vector 2 length is {vector1.GetLength()}");

            Console.WriteLine($"\nvector 1:\n{vector0.Normalize()}");
            Console.WriteLine($"\nvector 2:\n{vector1.Normalize()}");

            Console.WriteLine($"\nvector 1 and vector 2 dot product is {PositionVector.GetDotProduct(vector0, vector1)}");
        }
    }

    public struct PositionVector
    {
        public double X, Y;
        public PositionVector(double x, double y)
        {
            X = x;
            Y = y;
        }


        public double GetLength()
        {
            return Math.Sqrt((X * X) + (Y * Y));
        }
        public static double GetDotProduct(PositionVector v1, PositionVector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public string Normalize()
        {
            return $"normalized X is {X / GetLength()}\nnormalized Y is {Y / GetLength()}";
        }
    }
}
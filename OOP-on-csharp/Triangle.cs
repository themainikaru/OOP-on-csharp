using System;

namespace OOP_on_csharp
{
    internal class Triangle
    {
        public struct Point
        {
            public int X, Y;
            public Point(int x, int y)
            {
                X = x; Y = y;
            }
        }

        private readonly double _ab, _bc, _ac;
        public Triangle(Point pointA, Point pointB, Point pointC)
        {
            _ab = CalculateDistance(pointA, pointB);
            _bc = CalculateDistance(pointB, pointC);
            _ac = CalculateDistance(pointA, pointC);
        }

        public double AB => _ab;
        public double BC => _bc;
        public double AC => _ac;

        public double Perimeter => _ab + _bc + _ac;

        public double Area
        {
            get
            {
                double halfPerimeter = Perimeter / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - _ab) *
                               (halfPerimeter - _bc) * (halfPerimeter - _ac));
            }
        }


        private static double CalculateDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }


        public void PrintInfo()
        {
            Console.WriteLine($"AB = {_ab}\tBC = {_bc}\tAC = {_ac}");
            Console.WriteLine($"\nperimeter = {Perimeter:F2}");
            Console.WriteLine($"area = {Area:F2}");
        }
    }
}
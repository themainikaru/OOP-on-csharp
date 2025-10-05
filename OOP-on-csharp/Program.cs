using System;

namespace OOP_on_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle.Point pointA = new Triangle.Point(0, 0);
            Triangle.Point pointB = new Triangle.Point(3, 0);
            Triangle.Point pointC = new Triangle.Point(0, 4);

            Triangle triangle = new Triangle(pointA, pointB, pointC);
            triangle.PrintInfo();
        }
    }
}
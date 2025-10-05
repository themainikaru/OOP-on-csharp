using System;
using static OOP_on_csharp.Stereometry;

namespace OOP_on_csharp
{
    internal class Stereometry
    {
        public readonly struct Point
        {
            public readonly int X, Y, Z;
            public Point(int x, int y, int z)
            {
                X = x; Y = y; Z = z;
            }

            public double GetDistanceTo(Point anyPoint) => Stereometry.GetDistance(this, anyPoint);
            public void PrintDistanceTo(Point anyPoint)
            {
                Console.WriteLine($"distance between your points: {Stereometry.GetDistance(this, anyPoint):F2}");
            }
        }


        public static double GetDistance(Point point1, Point point2)
        {
            double distance = Math.Sqrt(
                (point2.X - point1.X) * (point2.X - point1.X) +
                (point2.Y - point1.Y) * (point2.Y - point1.Y) +
                (point2.Z - point1.Z) * (point2.Z - point1.Z)
                );

            return distance;
        }
    }
}
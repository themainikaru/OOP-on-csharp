using System;

namespace OOP_on_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stereometry.Point point1 = new Stereometry.Point(0, 0, 0);
            Stereometry.Point point2 = new Stereometry.Point(10, 10, 10);

            point1.PrintDistanceTo(point2);
        }
    }
}
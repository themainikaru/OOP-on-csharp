using System;

namespace OOP_on_csharp
{
    internal class Rectangle
    {
        private double _width, _height;
        public Rectangle(double width, double height)
        {
            if(width > 0 && height > 0)
            {
                _width = width;
                _height = height;
            }
        }

        public void PrintArea()
        {
            Console.WriteLine($"Площадь: { _width* _height}");
        }
    }
}
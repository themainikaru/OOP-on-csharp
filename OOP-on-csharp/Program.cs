using System;

namespace OOP_on_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = new Color(100, 255, 100);
            Console.WriteLine($"\u001b[48;2;{color.R};{color.G};{color.B}m  \u001b[0m {color.HexCode()}");
        }
    }

    public struct Color
    {
        public byte R;
        public byte G;
        public byte B;

        public Color(byte r, byte g, byte b)
        {
            R = r; G = g; B = b;
        }

        public string HexCode()
        {
            return $"#{R.ToString("X2") + G.ToString("X2") + B.ToString("X2")}";
        }
    }
}
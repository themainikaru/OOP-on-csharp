using System;

namespace OOP_on_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber complexNumber1 = new ComplexNumber(100, 100);
            ComplexNumber complexNumber2 = new ComplexNumber(200, 200);

            Sum();
            Subtraction();
            Multiplication();


            void Sum()
            {
                ComplexNumber complexNumber3 = new ComplexNumber(complexNumber1.Real + complexNumber2.Real, complexNumber1.Imag + complexNumber2.Imag);
                Console.WriteLine($"{complexNumber3.Real}, {complexNumber3.Imag}");
            }

            void Subtraction()
            {
                ComplexNumber complexNumber4 = new ComplexNumber(complexNumber1.Real - complexNumber2.Real, complexNumber1.Imag - complexNumber2.Imag);
                Console.WriteLine($"{complexNumber4.Real}, {complexNumber4.Imag}");
            }

            void Multiplication()
            {
                ComplexNumber complexNumber5 = new ComplexNumber(complexNumber1.Real * complexNumber2.Real, complexNumber1.Imag * complexNumber2.Imag);
                Console.WriteLine($"{complexNumber5.Real}, {complexNumber5.Imag}");
            }
        }
    }

    public struct ComplexNumber
    {
        public int Real;
        public int Imag;


        public ComplexNumber(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }
    }
}
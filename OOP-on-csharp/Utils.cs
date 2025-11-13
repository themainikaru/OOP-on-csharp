using System;

namespace OOP_on_csharp
{
    public class Utils
    {
        static public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}

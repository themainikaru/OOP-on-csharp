using System;

namespace OOP_on_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Date birthday = new Date(8, 1, 1984);

            Console.WriteLine(birthday.IsLeapYear());
        }
    }

    public struct Date
    {
        private byte _day;
        private byte _month;
        private short _year;

        public Date(byte day, byte month, short year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public bool IsLeapYear()
        {
            switch (_year % 4)
            {
                case 0:
                    return true;
                default:
                    return false;
            }
        }
    }
}
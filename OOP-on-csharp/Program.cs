using System;

namespace OOP_on_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "Преступление и наказание";
            book.Pages = 500;
            book.PrintInfo();
        }
    }


    public class Book
    {
        public string Title;
        private short _pages;
        public short Pages
        {
            get { return _pages; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("количество страниц не может быть отрицательным");
                _pages = value;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Title}, {Pages} страниц");
        }
    }
}
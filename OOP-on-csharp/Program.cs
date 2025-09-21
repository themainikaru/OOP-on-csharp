using System;

namespace OOP_on_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("Война и мир", "Толстой Л. Н.", 1867);
            Book book3 = new Book("Ониксовый шторм", "Ребекка Яррос");

            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
        }
    }


    public class Book
    {
        private string _name;
        private string _author;
        private int _year;


        public Book()
        {
            _name = "unknown";
            _author = "unknown";
            _year = 0;
        }

        public Book(string name, string author, int year)
        {
            _name = name;
            _author = author;
            _year = year;
        }

        public Book(string name, string author)
        {
            _name = name;
            _author = author;
            _year = 2024;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"{_name}\t{_author}\t{_year}");
        }
    }
}
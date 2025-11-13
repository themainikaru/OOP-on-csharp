using System;

namespace OOP_on_csharp
{
    internal class Book
    {
        public readonly string Title;
        public readonly ushort Pages;
        public Book(string title, ushort pages)
        {
            Title = title;

            if (pages > 0)
                Pages = pages;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Книга: \"{Title}\", страниц: {Pages}");
        }

        public void ChangeBookTitle(string newTitle)
        {
            Title = newTitle;
        }
    }
}
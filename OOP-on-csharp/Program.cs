using System;

namespace OOP_on_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Преступление и наказание", 500);
            book.PrintInfo();

            Rectangle rectangle = new Rectangle(10, 10);
            rectangle.PrintArea();

            Student student = new Student("Игнат", 5);
            student.PrintInfo();
        }
    }
}
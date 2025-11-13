using System;

namespace OOP_on_csharp
{
    internal class Student
    {
        private string _name;
        private byte _grade;
        public Student(string name, byte grade)
        {
            _name = name;
            if(1 <= grade <= 5)
                _grade = grade;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {_name}, оценка {_grade}");
        }
    }
}
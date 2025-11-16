using System;

namespace OOP_on_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.SetFullName("Иванов Иван Иванович");
            student.SetGroupName("СОИП24-ПР1");
            student.SetAge(17);
            student.SetParentsFullName("*ФИО родителя*");

            student.PrintInfo();
        }
    }


    public class Group
    {
        protected internal string _groupName;
    }


    public class Student : Group
    {
        private string FullName;
        private byte _age;
        private string _parentsFullName;
        internal byte inClassСorrectAnswers;

        public void SetFullName(string fullName)
        {
            FullName = fullName;
        }
        public void SetGroupName(string groupName)
        {
            _groupName = groupName;
        }
        public void SetAge(byte age)
        {
            _age = age;
        }
        public void SetParentsFullName(string parentsFullName)
        {
            _parentsFullName = parentsFullName;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FullName}\t{_groupName}\t{_age}\t{_parentsFullName}");
        }
    }
}
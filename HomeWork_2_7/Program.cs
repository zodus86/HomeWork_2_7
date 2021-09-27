using System;
using System.Collections.Generic;

namespace HomeWork_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //список студентов
            List<Student> students = new List<Student>();
            students.Add(new Student("Иванов И.И.", 25, "mail@mail.ru", 25, 35, 44));
            students.Add(new Student("Петров П.П.", 23, "mail@list.ru", 85, 65, 32));

             //форматированный вывод списка студенов задание 1 
            foreach (Student studend in students)
            {
                studend.Print();
            }

            Console.ReadKey();

            //форматированный вывод списка студенов задание 2 
            foreach (Student studend in students)
            {
                studend.PrintAverageScore();
            }

            Console.ReadKey();
        }
    }
}

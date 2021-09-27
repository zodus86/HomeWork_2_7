using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2_7
{
    /// <summary>
    /// Студенты
    /// </summary>
    class Student
    {
        private string fullName { get; set; }
        private int age { set; get; }
        private string email { set; get; }
        private double scoreProgram { set; get; }
        private double scoreMaths { set; get; }
        private double scorePhysics { set; get; }

        private double averageScore { set; get; }

        public Student (string fullName, int age, string email, double scoreProgram, double scoreMaths , double scorePhysics)
        {
            this.fullName = fullName;
            this.age = age;
            this.email = email;
            this.scoreMaths = scoreMaths;
            this.scorePhysics = scorePhysics;
            this.scoreProgram = scoreProgram;
            double score = (scoreMaths + scorePhysics + scoreProgram) / 3; 
            this.averageScore = score; 
        }
        public void PrintAverageScore()
        {
            Console.WriteLine($"{fullName} у студента средний бал : {averageScore}");
        }
        public void Print()
        {
            Console.WriteLine($"{fullName, 15} {age, 8} {email, 15} {scoreProgram, 15} {scoreMaths,15} {scorePhysics, 15}");
        }
    }
}

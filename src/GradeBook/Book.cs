using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades = new List<double>();
        private double lowestGrade;
        private double highestGrade;

        public string Name { get; private set; }

        public Book(string name)
        {
            Name = name;
            lowestGrade = double.MaxValue;
            highestGrade = double.MinValue;
        }

        public void ShowStatistics()
        {
            System.Console.WriteLine($"{Name}'s grade average is {CalculateAverage():N2}");
            System.Console.WriteLine($"{Name}'s highest grade is {GetHighestGrade():N2}");
            System.Console.WriteLine($"{Name}'s lowest grade is {GetLowestGrade():N2}");
        }

        public Statistics GetStatistics()
        {
            Statistics result = new Statistics();
            result.Average = CalculateAverage();
            result.HighestGrade = highestGrade;
            result.LowestGrade = lowestGrade;
            return result;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
            highestGrade = Math.Max(highestGrade, grade);
            lowestGrade = Math.Min(lowestGrade, grade);
        }

        public IReadOnlyCollection<double> GetGrades()
        {
            return grades;
        }

        public double GetHighestGrade()
        {
            return highestGrade;
        }

        public double GetLowestGrade()
        {
            return lowestGrade;
        }

        public double CalculateAverage()
        {
            if (grades.Count == 0)
            {
                return 0;
            }

            double result = 0.0;
            foreach(var grade in grades)
            {
                result += grade;
            }
            result /= grades.Count;
            return result;
        }
    }
}
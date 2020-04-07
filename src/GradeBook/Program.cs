using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book gradeBook = new Book("Scott");
            gradeBook.AddGrade(12.7);
            gradeBook.AddGrade(5.7);
            gradeBook.AddGrade(55.7);
            gradeBook.ShowStatistics();
        }
    }
}

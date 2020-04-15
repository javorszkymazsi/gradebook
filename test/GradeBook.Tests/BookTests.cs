using System;
using System.Collections.Generic;
using GradeBook;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void CalculateAverage_Success()
        {
            // arrange
            Book book = new Book("Scott");
            List<double> grades = new List<double>() {84.9, 106.7, 36.3, 84.9};
            foreach(var grade in grades)
            {
                book.AddGrade(grade);
            }
            
            // act
            double expectedAverage = 78.2;
            double actualAverage = book.CalculateAverage();

            // assert
            Assert.Equal(expectedAverage, actualAverage, 1);
        }

        [Fact]
        public void CalculateAverage_NoGrades()
        {
            // arrange
            Book book = new Book("Scott");
            List<double> grades = new List<double>() {};
            
            // act
            double actualAverage = book.CalculateAverage();

            // assert
            Assert.Equal(0, actualAverage);
        }

        [Fact]
        public void CalculateAverage_Null()
        {
            // arrange
            Book book = null;
            
            // act

            // assert
            Assert.Throws<NullReferenceException>(() => book.CalculateAverage());
        }
    }
}

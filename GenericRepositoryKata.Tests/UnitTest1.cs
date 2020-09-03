using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace GenericRepositoryKata.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_WithTwonumbers_houldreturnyheSumOfBothNumners()
        {
            // Arrange
            int number1 = 5;
            int number2 = 6;

            Calculator calculator = new Calculator();


            // Act
            int result = calculator.Sum(number1, number2);


            // Assert
            result.Should().Be(11);
        }


        [TestMethod]
        public void Sum_WhenGiven7And13_ShouldReturn20()
        {
            // Arrange
            int number1 = 7;
            int number2 = 13;

            Calculator calculator = new Calculator();


            // Act
            int result = calculator.Sum(number1, number2);


            // Assert
            result.Should().Be(20);
        }
    }
}

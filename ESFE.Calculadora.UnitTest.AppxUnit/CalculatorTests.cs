using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.Calculadora.UnitTest.AppxUnit
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            //Arrange
            calculator calculator = new calculator();
            double num1 = 5.0;
            double num2 = 3.0;

            // Act
            double result = calculator.Add(num1, num2);

            //Assert
            Assert.Equal(8.0, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            //Arrange
            calculator calculator = new calculator();
            double num1 = 8.0;
            double num2 = 3.0;

            //Act
            double result = calculator.Subtract(num1, num2);

            //Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            //Arrange
            calculator calculator = new calculator();
            double num1 = 4.0;
            double num2 = 2.0;

            // Act
            double result = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(8.0, result);
        }
        [Fact]
        public void Divide_ShouldReturnCorrectQuoient()
        {
            //Arrange
            calculator calculator = new calculator();
            double num1 = 10.0;
            double num2 = 2.0;

            // Act
            double result = calculator.Divide(num1, num2);

            // Assert
            Assert.Equal(5.0, result);
        }
        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            // Arrange
            calculator calculator = new calculator();
            double num1 = 5.0;
            double num2 = 0.0;

            //Act and assert
            Assert.Throws<ArgumentException>(() => calculator.Divide(num1,num2));
        }
    }
}

using System;
using xunit;
using Xunit;

namespace xUnit
{
    public class CalculatorTests
    {
        private readonly Calculator _sut;

        public CalculatorTests()
        {
            _sut = new Calculator();
        }

        [xunit.Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _sut.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Theory]
        [InlineData(10, 5, 15)]
        [InlineData(-2, 2, 0)]
        [InlineData(0, 0, 0)]
        public void Add_VariousNumbers_ReturnsCorrectSum(int a, int b, int expected)
        {
            // Act
            int result = _sut.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(-2, -2, 0)]
        [InlineData(0, 0, 0)]
        public void Subtract_VariousNumbers_ReturnsCorrectDifference(int a, int b, int expected)
        {
            // Act
            int result = _sut.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 5, 50)]
        [InlineData(-2, -2, 4)]
        [InlineData(0, 5, 0)]
        public void Multiply_VariousNumbers_ReturnsCorrectProduct(int a, int b, int expected)
        {
            // Act
            int result = _sut.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(-6, -2, 3)]
        [InlineData(5, 2, 2)]
        public void Divide_VariousNumbers_ReturnsCorrectQuotient(int a, int b, int expected)
        {
            // Act
            int result = _sut.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 0)]
        [InlineData(-6, 0)]
        public void Divide_ByZero_ThrowsException(int a, int b)
        {
            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _sut.Divide(a, b));
        }

        [Theory]
        [InlineData(int.MaxValue, 1)]
        public void Add_Overflow_ThrowsException(int a, int b)
        {
            // Act & Assert
            Assert.Throws<OverflowException>(() => _sut.Add(a, b));
        }
    }
}


using OOPConsoleApp;
using Xunit;

namespace UnitTestApp.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void CurrectSum()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int a = 5;
            int b = 3;
            // Act
            var result = calculator.Sum(a, b);
            // Assert
            Assert.Equal(8, result);
        }
    }
}
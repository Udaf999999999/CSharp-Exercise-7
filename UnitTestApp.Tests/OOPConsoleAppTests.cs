using Microsoft.VisualStudio.TestPlatform.TestHost;
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
    public class IndexingClassTest
    {
        [Fact]
        public void IndexCorrect()
        {
            // Arrange
            int[] a = { 3, 5, 6 };
            IndexingClass indexingClass = new IndexingClass(a);

            // Act
            var result = indexingClass[1];
            // Assert
            Assert.Equal(5, result);
        }
        [Fact]
        public void IndexLowerThenZero()
        {
            // Arrange
            int[] a = { 3, 5, 6 };
            IndexingClass indexingClass = new IndexingClass(a);

            // Act
            var result = indexingClass[-1];
            // Assert
            Assert.Equal(0, result);
        }
    }
}
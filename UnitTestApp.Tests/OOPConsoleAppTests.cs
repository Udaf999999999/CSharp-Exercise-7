using Microsoft.VisualStudio.TestPlatform.TestHost;
using OOPConsoleApp;
using System;
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
    public class HelperSwapTest
    {
        [Fact]
        public void SwapCurrectTest()
        {
            // Arrange
            int a = 10;
            int b = 20;
            // Act
            Helper.Swap(ref a, ref b);
            // Assert
            Assert.Equal(b, 10);
            Assert.Equal(a, 20);
        }
    }
    public class IntExtensionTest
    {
        [Fact]
        public void IntExtensionCorrect()
        {
            // Arrange
            int num1 = 7;
            int num12 = 7;
            int num2 = -13;
            int num22 = -13;
            int num3 = 0;
            // Act
            num1 = num1.GetPositive();
            num12 = num12.GetNegative();
            num2 = num2.GetPositive();
            num22 = num22.GetNegative();
            num3.GetNegative();
            // Assert
            Assert.Equal(7, num1);
            Assert.Equal(-7, num12);
            Assert.Equal(13, num2);
            Assert.Equal(-13, num22);
            Assert.Equal(0, num3);
        }
    }
}
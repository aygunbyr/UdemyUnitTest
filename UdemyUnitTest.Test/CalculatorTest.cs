using System.Collections.Generic;
using UdemyUnitTest.App;
using Xunit;

namespace UdemyUnitTest.Test
{
    public class CalculatorTest
    {
        private readonly Calculator _calculator;

        public CalculatorTest()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(2,5,7)]
        [InlineData(10,2,12)]
        public void Add_SimpleValues_ReturnsTotalValue(int a, int b, int expectedTotal) 
        {
            var actualTotal = _calculator.Add(a, b);

            Assert.Equal<int>(expectedTotal, actualTotal);
        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(10, 0, 0)]
        public void Add_ZeroValues_ReturnsZeroValue(int a, int b, int expectedTotal)
        {
            var actualTotal = _calculator.Add(a, b);

            Assert.Equal<int>(expectedTotal, actualTotal);
        }
    }
}

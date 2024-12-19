using Moq;
using System;
using UdemyUnitTest.App;
using Xunit;

namespace UdemyUnitTest.Test
{
    public class CalculatorTest
    {
        private readonly Calculator _calculator;
        private Mock<ICalculatorService> mymock;

        public CalculatorTest()
        {
            mymock = new Mock<ICalculatorService>();
            _calculator = new Calculator(mymock.Object);
        }

        [Theory]
        [InlineData(2,5,7)]
        [InlineData(10,2,12)]
        public void Add_SimpleValues_ReturnsTotalValue(int a, int b, int expectedTotal) 
        {

            mymock.Setup(x => x.add(a,b)).Returns(expectedTotal);

            var actualTotal = _calculator.add(a, b);

            Assert.Equal<int>(expectedTotal, actualTotal);

            mymock.Verify(x => x.add(a, b), Times.Once);
        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(10, 0, 0)]
        public void Add_ZeroValues_ReturnsZeroValue(int a, int b, int expectedTotal)
        {
            mymock.Setup(x => x.add(a, b)).Returns(expectedTotal);
            var actualTotal = _calculator.add(a, b);

            Assert.Equal<int>(expectedTotal, actualTotal);
        }

        [Theory]
        [InlineData(3, 5, 15)]
        public void Multip_SimpleValues_ReturnsMultipValue(int a, int b, int expectedValue)
        {
            //mymock.Setup(x => x.multip(a, b)).Returns(expectedValue);

            //Assert.Equal<int>(expectedValue, _calculator.multip(a, b));

            int actualMultip = 0;
            mymock.Setup(x => x.multip(It.IsAny<int>(), It.IsAny<int>())).Callback<int, int>((x, y) => actualMultip = x * y);

            _calculator.multip(a, b);

            Assert.Equal(expectedValue, actualMultip);

            _calculator.multip(5, 20);

            Assert.Equal(100, actualMultip);
        }

        [Theory]
        [InlineData(0, 5)]
        public void Multip_ZeroValue_ReturnsException(int a, int b)
        {
            mymock.Setup(x => x.multip(a, b)).Throws(new Exception("a=0 olamaz"));

            Exception exception = Assert.Throws<Exception>(()  => _calculator.multip(a, b));

            Assert.Equal("a=0 olamaz", exception.Message);
        }
    }
}

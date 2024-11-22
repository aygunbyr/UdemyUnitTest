using UdemyUnitTest.App;
using Xunit;

namespace UdemyUnitTest.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            // Arrange
            int a = 5;
            int b = 20;
            var calculator = new Calculator();

            // Act
            var total = calculator.Add(a, b);

            // Assert
            Assert.Equal<int>(a + b, total);
            //Assert.NotEqual<int>(a+b, total);
        }
    }
}

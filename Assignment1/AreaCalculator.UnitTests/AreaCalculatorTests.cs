using AreaCalculator.Implementations;
using Xunit;

namespace AreaCalculator.UnitTests
{
    public class AreaCalculatorTests
    {
        [Theory]
        [InlineData(3, 4, 5)]
        public void When_InputProvided_Should_ReturnCorrectResult(int a, int b, int c)
        {
            var sut = new AreaCalculatorCommands();

            var result = sut.CalculateArea(a, b, c);
            Assert.True(result == 6);
        }
    }
}
namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldDoOperation()
        {
            Assert.Equal(Calculator.DoOperation(1.5, 23.3, "a"), 24.8);
            Assert.Equal(Calculator.DoOperation(1.5, 23.3, "s"), -21.8);
            Assert.Equal(Calculator.DoOperation(1.5, 23.3, "m"), 34.95);
            Assert.Equal(Calculator.DoOperation(22.5, 1.5, "d"), 15);
            Assert.Equal(Calculator.DoOperation(1.5, 23.3, "qwe"), double.NaN);
        }
    }
}
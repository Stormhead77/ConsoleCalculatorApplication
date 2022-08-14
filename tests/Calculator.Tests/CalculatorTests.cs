namespace Calculator.Tests
{
    public class CalculatorTests
    {
        //readonly CalculatorLibrary.Calculator calculator = new();

        [Fact]
        public void ShouldDoAddition()
        {
            Assert.Equal(24.8, CalculatorLibrary.Calculator.DoOperation(1.5, 23.3, "a"));
        }

        [Fact]
        public void ShouldDoSubstraction()
        {
            Assert.Equal(-21.8, CalculatorLibrary.Calculator.DoOperation(1.5, 23.3, "s"));
        }

        [Fact]
        public void ShouldDoMultiplication()
        {
            Assert.Equal(34.95, CalculatorLibrary.Calculator.DoOperation(1.5, 23.3, "m"));
        }

        [Fact]
        public void ShouldDoDivision()
        {
            Assert.Equal(15, CalculatorLibrary.Calculator.DoOperation(22.5, 1.5, "d"));
        }

        [Fact]
        public void ShouldDoNothing()
        {
            Assert.Equal(double.NaN, CalculatorLibrary.Calculator.DoOperation(1.5, 23.3, "qwe"));
        }
    }
}
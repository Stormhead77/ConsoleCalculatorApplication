using ConsoleCalculatorApplication;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Calculator.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void ShouldDoRunWithMockConsole()
        {
            MockConsole mockConsole = new();
            Program program = new();
            program.MyConsole = mockConsole;
            mockConsole.Output.Enqueue("11");
            mockConsole.Output.Enqueue("31");
            mockConsole.Output.Enqueue("a");
            mockConsole.Output.Enqueue("n");

            program.RunCalculator();
            var expected =
                "Console Calculator in C#" +
                "------------------------" +
                "Type a number, and then press Enter: " +
                "Type another number, and then press Enter: " +
                "Choose an operator from the following list:" +
                "a - Add" +
                "s - Subtract" +
                "m - Multiply" +
                "d - Divide" +
                "Your option? " +
                "Your result: 42" +
                "------------------------" +
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expected, Regex.Replace(mockConsole.Inputs.ToString(), @"[\r\t\n]+", string.Empty));
        }

        [Fact]
        public void ShouldDoRunWithNotValidInputWithMockConsole()
        {
            MockConsole mockConsole = new();
            Program program = new();
            program.MyConsole = mockConsole;
            mockConsole.Output.Enqueue("a");
            mockConsole.Output.Enqueue("11");
            mockConsole.Output.Enqueue("s");
            mockConsole.Output.Enqueue("0");
            mockConsole.Output.Enqueue("d");
            mockConsole.Output.Enqueue("n");

            program.RunCalculator();
            var expected =
                "Console Calculator in C#" +
                "------------------------" +
                "Type a number, and then press Enter: " +
                "This is not valid input. Please enter an integer value: " +
                "Type another number, and then press Enter: " +
                "This is not valid input. Please enter an integer value: " +
                "Choose an operator from the following list:" +
                "a - Add" +
                "s - Subtract" +
                "m - Multiply" +
                "d - Divide" +
                "Your option? " +
                "This operation will result in a mathematical error." +
                "------------------------" +
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expected, Regex.Replace(mockConsole.Inputs.ToString(), @"[\r\t\n]+", string.Empty));
        }

        public void ShouldDoRun()
        {
            var qwe = new Mock
        }
    }
}
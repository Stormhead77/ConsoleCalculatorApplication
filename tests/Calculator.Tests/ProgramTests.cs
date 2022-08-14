using System.Text;
using System.Text.RegularExpressions;

namespace Calculator.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void ShouldDoRun()
        {
            StringWriter sw = new();
            Console.SetOut(sw);

            StringBuilder sb = new();
            sb.AppendLine("11");
            sb.AppendLine("31");
            sb.AppendLine("a");
            sb.AppendLine("n");

            StringReader sr = new(sb.ToString());
            Console.SetIn(sr);

            ConsoleCalculatorApplication.Program.Main();
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
            Assert.Equal(expected, Regex.Replace(sw.ToString(), @"[\r\t\n]+", string.Empty));
        }

        [Fact]
        public void ShouldDoRunWith()
        {
            StringWriter sw = new();
            Console.SetOut(sw);

            StringBuilder sb = new();
            sb.AppendLine("a");
            sb.AppendLine("11");
            sb.AppendLine("s");
            sb.AppendLine("0");
            sb.AppendLine("d");
            sb.AppendLine("n");

            StringReader sr = new(sb.ToString());
            Console.SetIn(sr);

            ConsoleCalculatorApplication.Program.Main();
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
            Assert.Equal(expected, Regex.Replace(sw.ToString(), @"[\r\t\n]+", string.Empty));
        }
    }
}
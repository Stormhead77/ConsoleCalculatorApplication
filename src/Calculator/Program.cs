using Calculator;

namespace ConsoleCalculatorApplication
{
    public class Program
    {
        public IConsole MyConsole = new DefaultConsole();

        public static void Main()
        {
            Program program = new Program();

            program.RunCalculator();
        }

        public void RunCalculator()
        {
            bool endApp = false;
            MyConsole.WriteLine("Console Calculator in C#\r");
            MyConsole.WriteLine("------------------------\n");
            
            while (!endApp)
            {

                MyConsole.Write("Type a number, and then press Enter: ");
                string numInput1 = MyConsole.ReadLine();

                double cleanNum1;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    MyConsole.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = MyConsole.ReadLine();
                }

                MyConsole.Write("Type another number, and then press Enter: ");
                string numInput2 = MyConsole.ReadLine();

                double cleanNum2;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    MyConsole.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = MyConsole.ReadLine();
                }

                MyConsole.WriteLine("Choose an operator from the following list:");
                MyConsole.WriteLine("\ta - Add");
                MyConsole.WriteLine("\ts - Subtract");
                MyConsole.WriteLine("\tm - Multiply");
                MyConsole.WriteLine("\td - Divide");
                MyConsole.Write("Your option? ");

                string op = MyConsole.ReadLine();

                double result = CalculatorLibrary.Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    MyConsole.WriteLine("This operation will result in a mathematical error.\n");
                }
                else MyConsole.WriteLine("Your result: {0:0.##}\n", result);

                MyConsole.WriteLine("------------------------\n");

                MyConsole.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (MyConsole.ReadLine() == "n") endApp = true;

                MyConsole.WriteLine("\n");
            }

            return;
        }
    }
}
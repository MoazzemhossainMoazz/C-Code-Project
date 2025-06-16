using MyApp.Display;
using MyApp.Operations;

namespace MyApp.Operations
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;
    }
}

namespace MyApp.Display
{
    public class Printer
    {
        public void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}


public class Program
{
    public static void Main()
    {
        Calculator calc = new Calculator();
        Printer printer = new Printer();

        int sum = calc.Add(10, 5);
        int difference = calc.Subtract(10, 5);

        printer.Show($"Sum: {sum}");
        printer.Show($"Difference: {difference}");
    }
}



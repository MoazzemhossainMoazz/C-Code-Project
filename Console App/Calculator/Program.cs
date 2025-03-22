class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Do you want to continue? (y/n): ");
            string input = Console.ReadLine()?.ToLower();

            if(input == "n")
            {
                Console.WriteLine("Exiting the process...");
                break;
            }
            else if(input == "y")
            {
                Console.WriteLine("Enter First Number.");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Number.");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Operator (+, -, *, /, %)");
                char op = Console.ReadKey().KeyChar;

                double result;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine("\nThe result is: " + result);
                        break;

                    case '-':
                        result = num1 - num2;
                        Console.WriteLine("\nThe result is: " + result);
                        break;

                    case '*':
                        result = num1 * num2;
                        Console.WriteLine("\nThe result is: " + result);
                        break;

                    case '/':
                        result = num1 / num2;
                        Console.WriteLine("\nThe result is: " + result);
                        break;

                    case '%':
                        result = num1 % num2;
                        Console.WriteLine("\nThe result is: " + result);
                        break;
                }
            }
            else
            {
                Console.WriteLine("invalid input! please type 'y' to continue or type 'n' to break the process.");
            }
        }

       
    }
}
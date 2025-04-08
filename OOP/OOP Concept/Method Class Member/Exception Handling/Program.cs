using System.Security.Cryptography.X509Certificates;

public class test
{
   public static void Main()
    {
        Console.WriteLine($"Welcmoe to the calculator");

        try
        {
            Console.Write($"Enter num1 = ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter num2 = ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine($"Result is: {result}");
        }
        catch (OverflowException)
        {
            Console.WriteLine($"Number was too big or small");
        }
        catch (FormatException)
        {
            Console.WriteLine($"Please enter valid input");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Zero is not possible for this task.");
        }
        catch(Exception e)
        {
            Console.WriteLine($"{e}");
        }
        finally
        {
            Console.WriteLine($"End");
        }
        
    }
}
using System.Security.Cryptography.X509Certificates;

public class test
{
   public static void Main()
    {
        Console.WriteLine($"Welcmoe to the calculator");

        try
        {
            

            Console.WriteLine($"Enter num1 = ");
            string input1 = Console.ReadLine() ?? "";
            if (string.IsNullOrEmpty(input1)) 
            {
                throw new ArgumentNullException("num1 can not be null or empty");
            }
            int num1 = Convert.ToInt32(input1);


            Console.WriteLine($"Enter num2 = ");
            string input2 = Console.ReadLine() ?? "";
            if (string.IsNullOrEmpty(input2))
            {
                throw new ArgumentException("num2 can not be null or empty");
            }
            int num2 = Convert.ToInt32(input2);


            int result = num1 / num2;
            Console.WriteLine($"Result is: {result}");
            
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine($"Error: Input can not be null or empty");
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
        catch(ArgumentException e)
        {
            Console.WriteLine($"{e.Message}");
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
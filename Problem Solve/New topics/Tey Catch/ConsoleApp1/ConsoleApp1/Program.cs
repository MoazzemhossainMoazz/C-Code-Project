public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

public class Person
{
    public void Register(int age)
    {
        if(age < 0 || age > 130)
        {
            throw new InvalidAgeException("Invalid age entered.");
        }
        Console.WriteLine("Registration Successful.");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        try
        {
            person.Register(150);
        }
        catch(InvalidAgeException ex)
        {
            Console.WriteLine("Custom error: " + ex.Message);
        }
    }
}
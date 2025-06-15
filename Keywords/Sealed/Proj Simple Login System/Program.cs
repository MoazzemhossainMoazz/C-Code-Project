public sealed class AuthManager
{
    private string storedUsername = "admin";
    private string storedPassword = "1234";

    public bool Login(string username, string password)
    {
        if (username == storedUsername && password == storedPassword)
        {
            Console.WriteLine("Login Successfull");
            return true;
        }
        else
        {
            Console.WriteLine("Invalid Username or Password");
            return false;
        }
    }
}

public class Program
{
    public static void Main()
    {
        AuthManager auth = new AuthManager();

        Console.Write("Username: ");
        string? user = Console.ReadLine();

        Console.Write("Password: ");
        string? pass = Console.ReadLine();

        auth.Login(user ?? "", pass ?? "");
    }
}
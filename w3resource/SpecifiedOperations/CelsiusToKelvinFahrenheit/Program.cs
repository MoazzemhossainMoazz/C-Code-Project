class CtoKF
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Enter a num: ");
        float Cel = float.Parse(Console.ReadLine());

        float K = Cel + 273;
        float F = Cel * 9 / 5 + 32;

        Console.WriteLine($"Kelvin: {K}");
        Console.WriteLine($"Fahrenheit: {F}");
    }
}
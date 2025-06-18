public class Circle
{
    private const double PI = 3.1416;

    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    public static void Main()
    {
        Circle circle = new Circle();
        double c = circle.CalculateArea(4.5);
        Console.WriteLine("Area is: " + c);
    }
}
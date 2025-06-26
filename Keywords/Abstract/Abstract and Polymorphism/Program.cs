abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double Radius;
    public Circle(double r)
    {
        Radius = 5;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Height, Width;
    public Rectangle(double h, double w)
    {
        Height = h;
        Width = w;
    }

    public override double Area()
    {
        return Height * Width;
    }

}

class Triangle : Shape
{
    public double Height, Width;
    public Triangle(double h, double w)
    {
        Height = h;
        Width = w;
    }

    public override double Area()
    {
        return 0.5 * Height * Width;
    }

}

class Program
{
    public static void Main(string[] args)
    {
        double h = 5, w = 6, r = 4.5;

        Circle cr = new Circle(r);
        Console.WriteLine(cr.Area());


        Rectangle rt = new Rectangle(h, w);
        Console.WriteLine(rt.Area());


        Triangle tr = new Triangle(h, w);
        Console.WriteLine(tr.Area());
    }
}

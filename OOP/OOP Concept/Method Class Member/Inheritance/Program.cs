class Animal
{
    public string name = "Dog";
    public void food()
    {
        Console.WriteLine("Fish");
    }
}

class Cat : Animal
{
    public string name = "Meni";
}

class AnimInfo
{
    public static void Main(string[] args)
    {
        Animal a1 = new Animal();
        Cat c1 = new Cat();

        c1.food();
        Console.WriteLine($"{a1.name}");
        Console.WriteLine($"{c1.name}");
    }
}
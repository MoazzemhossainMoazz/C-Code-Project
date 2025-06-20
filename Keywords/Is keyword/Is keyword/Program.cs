class Animal { }
class Cat : Animal { }
class Program
{
    public static void Main()
    {
        Animal pet = new Cat();

        object obj = 42.3;

        if(obj is int number)
        {
            Console.WriteLine("Integer number.");
        }
        else
        {
            Console.WriteLine("Float number.");
        }

        if (pet is Cat)
        {
            Console.WriteLine("Pet is Cat");
        }
    }
}
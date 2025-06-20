class Animal { }
class Cat : Animal { }
class Program
{
    public static void Main()
    {
        Animal pet = new Cat();

        object obj = 42.2;

        if(obj is int number)
        {
            Console.WriteLine("Number " + number + " integer number.");
        }
        //else
        //{
        //    Console.WriteLine("Number " + number + " float number.");
        //}

        if(pet is Cat)
        {
            Console.WriteLine("Pet is Cat");
        }
    }
}
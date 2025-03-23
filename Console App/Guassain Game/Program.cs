using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Do you want to continue? (y/n): ");
            string input = Console.ReadLine()?.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Exiting the process...");
                break; 
            }
            else if (input == "y")
            {

                Random rd = new Random();
                int rand_num = rd.Next(1, 10);

                for (int i=1; i<=5; i++)
                {

                    //Console.WriteLine("The random number is: " + rand_num);

                    Console.WriteLine("\nEnter a value between 1 to 10");
                    int number = int.Parse(Console.ReadLine());

                    if (number == rand_num)
                    {
                        
                        Console.WriteLine("Congratulation!!! You guass is right.\n");
                        Console.WriteLine("-----------------------------------------\n");
                        break;
                    }
                    else
                    {
                        int trial = 5 - i;

                        if (trial > 0)
                            Console.WriteLine("You loss! You can try " + trial + " more time.");
                        else
                            Console.WriteLine("You lose!!! Now you recharge 10 taka on this number 01900000.");
                    }
                }
               
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter 'y' to continue or 'n' to exit.");
            }
        }
    }
}
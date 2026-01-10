using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();
            return Name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int Number = int.Parse(Console.ReadLine());
            return Number;
        }

        static int SquareNumber(int Number)
        {
            return Number * Number;
        }

        static void DisplayResult(string Name ,int squaredNumber)
        {
            Console.WriteLine($"{Name}, the square of your favorite number is {squaredNumber}.");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }
}
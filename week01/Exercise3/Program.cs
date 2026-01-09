using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Magic Number Guess?");
        //generate a random number in the system for user to guess right.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int userGuess;
        do
        {
        Console.WriteLine("What is your guess?");
        userGuess = int.Parse(Console.ReadLine());
        if (userGuess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if(userGuess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed right!");
        }
        }  while (magicNumber != userGuess);
        
    }
}
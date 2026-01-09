using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Percentage Score");
        int score = int.Parse(Console.ReadLine());
        string letter;
        if (score >= 90)
        {
            letter = "A";
        }

        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine("Your grade is " + letter);

        //if statement  to determine the user passed the course
        if (score >= 70)
        {
            Console.WriteLine("Congratulations!!! You passed.");
        }
        else
        {
            Console.WriteLine("You didn't pass. Try Again.");
        }
    }
}
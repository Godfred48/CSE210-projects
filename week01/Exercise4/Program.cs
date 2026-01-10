using System;

class Program
{
    static void Main(string[] args)
    {
        //create a list to hold user input numbers
        List<int> numbers = new List<int>();
        int sum = 0;
        int average;
        Console.WriteLine("Enter a series of numbers. Type 0 when you are done!");
        int userInput;
        //Add user input to the list until user types 0
        do {Console.Write("Enter a number:");
        userInput = int.Parse(Console.ReadLine());
        numbers.Add(userInput);
        sum += userInput;

        if (userInput == 0)
        {
            //dosent add 0 to the list when user is done
            numbers.Remove(userInput);
        } 
        }while (userInput != 0);

        //Display the sum of the numbers
        Console.WriteLine($"The sum is: {sum}");

        //Calculate and display the average of the numbers
        average = sum / numbers.Count;
        Console.WriteLine($"The average is :{average}");
        
        //Maximim number in the list
        int maximum =  numbers[0];
        foreach(int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The largest number is: {maximum}");

    }
}
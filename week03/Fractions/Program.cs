using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction f1 = new Fraction();
       Fraction f2 = new Fraction( 6 );
       Fraction f3 = new Fraction(5,6);
       f1.Display();
       f2.Display();
       f3.Display();
        // Using getters to get values
        // Using getters
Console.WriteLine($"f3 top: {f3.GetTop()}, bottom: {f3.GetBottom()}");

// Using setters
f3.SetTop(10);
f3.SetBottom(3);

// Verify changes
Console.WriteLine($"After update, f3 top: {f3.GetTop()}, bottom: {f3.GetBottom()}");

// Display updated fraction
f3.Display();
    }
}
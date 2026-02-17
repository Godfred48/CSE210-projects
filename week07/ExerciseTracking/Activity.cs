using System;

public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    // Abstract methods (Required by rubric)
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual-style polymorphism usage (DO NOT override in children)
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthMinutes} min) - " +
               $"Distance {GetDistance():0.00} km, " +
               $"Speed {GetSpeed():0.00} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
}

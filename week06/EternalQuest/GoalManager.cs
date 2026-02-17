using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    private List<string> _achievements;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
        _achievements = new List<string>();
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"\nLevel: {_level} | Score: {_score}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == 3)
        {
            Console.Write("Target: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points!");

        ShowEncouragement();
        CheckLevelUp();
        CheckAchievements();
    }

    private void CheckLevelUp()
    {
        int newLevel = (_score / 1000) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine("🎉 LEVEL UP!");
        }
    }

    private void CheckAchievements()
    {
        if (_score >= 1000 && !_achievements.Contains("Score Master"))
        {
            _achievements.Add("Score Master");
            Console.WriteLine("🏆 Achievement Unlocked: Score Master!");
        }
    }

    private void ShowEncouragement()
    {
        string[] messages =
        {
            "🔥 Keep pushing forward!",
            "💪 You are building greatness!",
            "🚀 Progress, not perfection!",
            "🌟 Consistency wins!"
        };

        Random rand = new Random();
        Console.WriteLine(messages[rand.Next(messages.Length)]);
    }

    private void SaveGoals()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);
        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
            else if (parts[0] == "EternalGoal")
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            else if (parts[0] == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
        }
    }
}

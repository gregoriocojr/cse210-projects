using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:\n" +
            "1. Create New Goal\n" +
            "2. List Goals\n" +
            "3. Save Goals\n" +
            "4. Load Goals\n" +
            "5. Record Event\n" +
            "6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your score is: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("");
        Console.WriteLine("The types of Goals are:\n" +
            "1. Simple Goal\n" +
            "2. Eternal Goal\n" +
            "3. Checklist Goal\n");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("");
        Console.WriteLine("List of Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        ReturnToMenu();
    }

    public void CreateGoal()
    {
        ListGoalNames();
        Console.Write("Which type of goal would you like to create? ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            string name, description;
            int points, target, bonus;

            Console.Write("Enter goal name: ");
            name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            description = Console.ReadLine();
            Console.Write("Enter goal points: ");
            if (!int.TryParse(Console.ReadLine(), out points))
            {
                Console.WriteLine("Invalid input for points. Please enter a valid number.");
                return;
            }

            switch (choice)
            {
                case 1:
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case 2:
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case 3:
                    Console.Write("Enter goal target: ");
                    if (!int.TryParse(Console.ReadLine(), out target))
                    {
                        Console.WriteLine("Invalid input for target. Please enter a valid number.");
                        return;
                    }
                    Console.Write("Enter goal bonus: ");
                    if (!int.TryParse(Console.ReadLine(), out bonus))
                    {
                        Console.WriteLine("Invalid input for bonus. Please enter a valid number.");
                        return;
                    }
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid goal type.");
                    break;
            }
            Console.WriteLine("Goal created and added to the list.");
            ReturnToMenu();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for the goal type.");
            Console.ReadLine();
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("");
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]. ShortName}");
        }

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record events for.");
            Console.ReadLine();
            return;
        }

        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int selectedGoalNumber) && selectedGoalNumber > 0 && selectedGoalNumber <= _goals.Count)
        {
            Goal selectedGoal = _goals[selectedGoalNumber - 1];
            _score += selectedGoal.Points;
            Console.WriteLine($"Congratulations! You have earned {selectedGoal.Points} points!");
            Console.WriteLine($"You now have {_score} points.");
            ReturnToMenu();
        }

        else
        {
            Console.WriteLine("Invalid goal index. Please enter a valid index.");
            Console.ReadLine();
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goals saved to {filename}.");
        ReturnToMenu();
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length < 3)
                    {
                        Console.WriteLine("Invalid data in the file.");
                        Console.ReadLine();
                        return;
                    }

                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if (type == "SimpleGoal")
                    {
                        _goals.Add(new SimpleGoal(name, description, points));
                    }
                    else if (type == "EternalGoal")
                    {
                        _goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (type == "ChecklistGoal")
                    {
                        if (parts.Length < 6)
                        {
                            Console.WriteLine("Invalid data in the file.");
                            Console.ReadLine();
                            return;
                        }
                        int amountCompleted = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    }
                }
                Console.WriteLine($"Goals loaded from {filename}.");
                ReturnToMenu();
            }
        }
        else
        {
            Console.WriteLine("File not found. No goals loaded.");
            Console.ReadLine();
        }
    }

    // Added to handle returning to main menu
    public void ReturnToMenu()
    {
        string action = "";
        while (action == "")
        {
            Console.WriteLine("");
            Console.WriteLine("Press Enter to return to the main menu.");

            if(Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                break;
            }
        }
    }
}

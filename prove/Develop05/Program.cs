using System;

class Program
{
    static GoalManager goalManager = new GoalManager();

    static void Main(string[] args)
    {
        do
        {
            goalManager.Start();
            string action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoalDetails();
                    break;
                case "3":
                    Console.Write("Enter the file name to save goals: ");
                    string saveFileName = Console.ReadLine();
                    goalManager.SaveGoals(saveFileName);
                    break;
                case "4":
                    Console.Write("Enter the file name to load goals: ");
                    string loadFileName = Console.ReadLine();
                    goalManager.LoadGoals(loadFileName);
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine("Thank you for using the Eternal Goal Program.");
                    Console.WriteLine("See you again next time. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid choice (1, 2, 3, 4, 5, or 6).");
                    break;
            }
        } while (true);
    }
}

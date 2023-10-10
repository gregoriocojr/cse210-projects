public class ReflectingActivity: Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    
    public ReflectingActivity()
        : base("Reflecting Activity",
            "This activity will help you reflect on times in your " +
            "life when you have shown strength and resilience. " +
            "This will help you recognize the power you have and " +
            "how you can use it in other aspects of your life.", 0)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        do
        {
            DisplayStartingMessage();

            if (_duration <= 20)
            {
                // Added codes to handle cases where the user enters too short duration
                Console.WriteLine("");
                Console.WriteLine("The duration is too short for a reflecting activity.");
                Console.WriteLine("Please provide a duration of more than 20 seconds.");
                Thread.Sleep(5000);
                Console.Clear();
                continue;
            }

            else
            {
                ShowSpinner(3);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Consider the following prompt:");
                Console.WriteLine("");
                DisplayPrompt();

                string action = "";

                while (action == "")
                {
                    Console.WriteLine("");
                    Console.WriteLine("When you have something in mind, " +
                        "press Enter to continue.");

                    if(Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                    break;
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("Now ponder on each of the following " +
                    "as they related to this experience.");
                Console.Write("You may begin in: ");
                ShowCountDown(5);
                Console.Clear();
                
                int numberOfQuestions = 0;
                int remainder = _duration % 10;
                int x = 0;

                if (remainder > 5)
                {
                    numberOfQuestions = (_duration / 10) + 1;
                }
                else
                {
                    numberOfQuestions = _duration / 10;
                }

                for (int i = 0; i < numberOfQuestions; i++)
                {
                    if (i == 0)
                    {
                        if (remainder < 5)
                        {
                            x = remainder + 5;
                        }
                        else
                        {
                            x = remainder;
                        }
                    }
                    else
                    {
                        x = 10;
                    }
                    Console.WriteLine("");
                    DisplayQuestions();
                    ShowSpinner(x);
                    Console.WriteLine("");
                }
            }
            DisplayEndingMessage();
            break;
        } while (true);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompts = _prompts[index];
        return prompts;
    }

    public string GetRandomQuestions()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string questions = _questions[index];
        return questions;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestions()} ");
    }
}
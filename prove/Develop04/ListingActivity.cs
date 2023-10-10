public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts;
    
    public ListingActivity()
        : base("Listing Activity", "This activity will help you " +
            "reflect on the good things in your life by having you " +
            "as many things as you can in a certain area.", 0)
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {        
        do
        {
            DisplayStartingMessage();

            if (_duration <= 10)
            {
                // Added codes to handle cases where the user enters too short duration
                Console.WriteLine("");
                Console.WriteLine("The duration is too short for a full listing activity.");
                Console.WriteLine("Please provide a duration of more than 10 seconds.");
                Thread.Sleep(5000);
                Console.Clear();
                continue;
            }

            else
            {
                ShowSpinner(3);

                Console.WriteLine("");
                Console.WriteLine("List as many responses you can to the following prompt.");
                Console.WriteLine($"--- {GetRandomPrompt()} ---");
                Console.Write("You may begin in: ");
                ShowCountDown(5);
                Console.WriteLine("");

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(_duration);

                while (DateTime.Now < endTime)
                {
                    GetFromUser();
                    _count ++;
                }
            }
            Console.WriteLine($"You have listed {_count} items.");
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

    public List<string> GetFromUser()
    {
        List<string> userResponses = new List<string>();
        Console.Write("> ");
        string response = Console.ReadLine();
        userResponses.Add(response);
        return userResponses;
    }
}
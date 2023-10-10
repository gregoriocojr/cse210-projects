public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for this session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready ...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Thread.Sleep(1500);
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> animationSymbols = new List<string>
        {
            "|", "/", "-", "\\"
        };

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string symbol = animationSymbols[i];
            Console.Write(symbol);
            Thread.Sleep(200);
            Console.Write("\b \b");

            i++;

            if (i >= animationSymbols.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
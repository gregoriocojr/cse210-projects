public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
            "This activity will help you relax by walking " +
            "you through breathing in and out slowly. " +
            "Clear your mind and focus on your breathing.", 0)
    {}

    public void Run()
    {
        do
        {
            DisplayStartingMessage();

            if (_duration <= 10)
            {
                // Added codes to handle cases where the user enters too short duration
                Console.WriteLine("");
                Console.WriteLine("The duration is too short for a full breathing cycle.");
                Console.WriteLine("Please provide a duration of more than 10 seconds.");
                Thread.Sleep(5000);
                Console.Clear();
                continue;
            }

            else
            {
                int numberOfCycles = _duration / 10;
                int remainder = _duration % 10;
                
                int x = (remainder < 5) ? (3 + remainder) : 3;
                ShowSpinner(x);
                Console.WriteLine("");

                // These codes handles the odd or even remainder of seconds
                // when divided by a cycle of breathe in and breathe out
                if (remainder > 5)
                {
                    int remainingBreatheIn = remainder/2;
                    int remainingBreatheOut = remainder - remainingBreatheIn;

                    if (remainder % 2 != 0)
                    {
                        remainingBreatheIn += 1;
                        remainingBreatheOut -= 1;
                    }

                    Console.WriteLine("");
                    Console.Write($"Breathe in ... ");
                    ShowCountDown(remainingBreatheIn);
                    Console.WriteLine("");

                    Console.Write($"Now breathe out ... ");
                    ShowCountDown(remainingBreatheOut);
                    Console.WriteLine("");
                    }

                for (int i = 0; i < numberOfCycles; i++)
                {
                    Console.WriteLine("");
                    Console.Write("Breathe in ... ");
                    ShowCountDown(5);
                    Console.WriteLine("");

                    Console.Write("Now breathe out ... ");
                    ShowCountDown(5);
                    Console.WriteLine("");
                }
            }
            DisplayEndingMessage();
            break;
        } while (true);
    }
}
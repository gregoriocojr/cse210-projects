using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            Random randomGenerator = new Random();
            int intNumber = randomGenerator.Next(1, 100);

            Console.WriteLine("");
            Console.WriteLine("Welcome to the Number Guessing Game! (1 to 100)");

            int intGuess;
            int guessCount = 0;

            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                intGuess = int.Parse(guess);
                guessCount = guessCount + 1;
                if (intGuess > intNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (intGuess < intNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    // Console.WriteLine($"It took you {guessCount} guesses.");
                }
                // Console.WriteLine($"It took you {guessCount} guesses.");
            } while (intNumber != intGuess);
            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no) ");
            response = Console.ReadLine();

        }while (response == "yes");

        Console.WriteLine("Thank you for playing. Goodbye!");
    }
}
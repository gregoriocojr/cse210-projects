using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write($"What is the magic number? ");
        string number = Console.ReadLine();
        int intNumber = int.Parse(number);

        int intGuess;

        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            intGuess = int.Parse(guess);

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
            }
        } while (intNumber != intGuess);
    }
}
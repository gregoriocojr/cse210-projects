// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         //SEGMENT 1: Pause for a while before implementing the next sets of codes
//         // Console.WriteLine("");
//         // Console.WriteLine("*SEGMENT 1");
//         // Console.WriteLine("Hello Sandbox World!");
//         int x; // In milliseconds, meaning x = 1000 is 1 sec
//         // x = 3000; 
//         // Thread.Sleep(x); // Element of pausing
//         // Console.WriteLine("Done.");
//         // Thread.Sleep(2 * x); // Pause twice as long

//         //SEGMENT 2: Implementation of a countdown timer 
//         // Console.WriteLine("");
//         // Console.WriteLine("*SEGMENT 2");
//         // Console.WriteLine("Hello Sandbox World!");
//         // x = 1000;
//         // Console.WriteLine(5); // Countdown, lengthy codes
//         // Thread.Sleep(x);
//         // Console.WriteLine(4);
//         // Thread.Sleep(x);
//         // Console.WriteLine(3);
//         // Thread.Sleep(x);
//         // Console.WriteLine(2);
//         // Thread.Sleep(x);
//         // Console.WriteLine(1);
//         // Thread.Sleep(x);

//         // Console.Clear(); // Clears the entire screen
//         // Console.WriteLine("Done.");

//         //SEGMENT 3: Implementation of a countdown timer, shortened 
//         // Console.WriteLine("");
//         // Console.WriteLine("*SEGMENT 3");
//         // Console.WriteLine("Hello Sandbox World!");
//         x = 1000;

//         // for (int i = 5; i > 0; i--) // Get rid of repeating codes
//         // {
//             // Console.WriteLine(i); // Display one number per line.
//         //     Console.Write(i); //Display all in the same line
//         //     Thread.Sleep(x);
//         //     Console.Write("\b \b"); // Overwrite the displayed character
//         // }

//         // Console.Clear(); // Clears the entire screen
//         // Console.WriteLine("Done.");

//         //SEGMENT 4: Instead of numbers, use periods
//         // Console.WriteLine("");
//         // Console.WriteLine("*SEGMENT 4");
//         // Console.WriteLine("Hello Sandbox World!");

//         // for (int i = 5; i > 0; i--) // Get rid of repeating codes
//         // {
//             // Console.WriteLine(i); // Display one number per line.
//         //     Console.Write("."); //Display all in the same line
//         //     Thread.Sleep(x);
//             // Console.Write("\b \b"); // Overwrite the displayed character
//         // }

//         // Console.Clear(); // Clears the entire screen
//         // Console.WriteLine("Done.");

//         // SEGMENT 5: Spinner
//         // Console.WriteLine("");
//         // Console.WriteLine("*SEGMENT 5");
//         // Console.WriteLine("Hello Sandbox World!");

//         // List<string> animationSymbols = new List<string>
//         // {
//         //     "|", "/", "-", "\\", "|", "/", "-", "\\", "|"
//         // };

//         // foreach (string symbol in animationSymbols)
//         // {
//         //     Console.Write(symbol);
//         //     Thread.Sleep(x);
//         //     Console.Write("\b \b");
//         // }
//         // Console.Clear(); // Clears the entire screen
//         // Console.WriteLine("Done.");

//         // SEGMENT 6: Spinner with time element (variation)
//         // Console.WriteLine("");
//         // Console.WriteLine("*SEGMENT 6");
//         // Console.WriteLine("Hello Sandbox World!");

//         // DateTime startTime = DateTime.Now;
//         // DateTime endTime = startTime.AddSeconds(20);

//         // List<string> animationSymbols = new List<string>
//         // {
//         //     "|", "/", "-", "\\", "|", "/", "-", "\\", "|"
//         // };

//         // while (DateTime.Now < endTime)
//         // {
//         //     foreach (string symbol in animationSymbols)
//         //     {
//         //         Console.Write(symbol);
//         //         Thread.Sleep(x);
//         //         Console.Write("\b \b");
//         //     }
//         // }
//         // Console.Clear(); // Clears the entire screen
//         // Console.WriteLine("Done.");

//         // SEGMENT 6: Spinner with time element
//         Console.WriteLine("");
//         Console.WriteLine("*SEGMENT 6");
//         Console.WriteLine("Hello Sandbox World!");

//         DateTime startTime = DateTime.Now;
//         DateTime endTime = startTime.AddSeconds(20);

//         List<string> animationSymbols = new List<string>
//         {
//             "|", "/", "-", "\\", "|", "/", "-", "\\", "|"
//         };

//         int i = 0;

//         while (DateTime.Now < endTime)
//         {
//             string symbol = animationSymbols[i];
//             Console.Write(symbol);
//             Thread.Sleep(x);
//             Console.Write("\b \b");

//             i++;

//             if (i >= animationSymbols.Count)
//             {
//                 i = 0;
//             }
//         }
//         // Console.Clear(); // Clears the entire screen
//         Console.WriteLine("Done.");
//     }
// }


public class Game
{
    // All Games have a name
    private string _name;

    // All Games will use this constructor to set the name
    public Game(string name)
    {
        _name = name;
    }

    // Standard start for all games.  Each game should call this function before starting the game.
    public void DisplayStart()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to {_name}!");
        ReadySetGo();       
        Console.WriteLine(); 
    }

    // Standard end for all games.  Each game should call this function when its done.
    public void DisplayEnd()
    {
        Console.WriteLine();
        Console.WriteLine("Game over.  Hope you had fun!");
        Console.WriteLine();
    }

    // Displays Ready, Set, Go with 1 second pause in between each word
    private void ReadySetGo()
    {
        Console.Write("Ready....");
        Thread.Sleep(1000);
        Console.Write(" Set....");
        Thread.Sleep(1000);
        Console.WriteLine(" Go!");
    }

}







// Math Game is a type of Game (inheritance)

public class MathGame : Game
{
    // MathGame constructor calls the Game constructor
    public MathGame() : base("Math Game")
    {
    }

    // Display the start, play the game, and display the end
    // User has to solve an addition problem.
    public void Play()
    {
        DisplayStart();  // Calls from Parent class

        Random random = new Random();
        int a = random.Next(10);
        int b = random.Next(10);
        Console.Write($"What is {a} + {b}? ");
        int guess = int.Parse(Console.ReadLine());
        if (guess == a+b)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine($"Incorrect!  Answer was {a+b}");
        }

        DisplayEnd();  // Calls from Parent class
    }
}














// Guessing Game is a type of Game (inheritance)

public class GuessingGame : Game
{
    private int _mystery_number;
    private int _num_guesses;

    // GuessingGame constructor calls the Game constructor
    public GuessingGame() : base("Guessing Game")
    {
        // Randomly select the mystery number 0-100
        Random random = new Random();
        _mystery_number = random.Next(101);
        _num_guesses = 0;
    }

    // Display the start, play the game, and display the end
    // User will get multiple guesses and will be told to 
    // go higher or lower.  The number of guess is tracked.
    public void Play()
    {
        DisplayStart();  // Calls from Parent class
        int guess = -1;
        do
        {
            _num_guesses += 1;
            Console.Write("What is your guess (0-100): ");
            guess = int.Parse(Console.ReadLine());
            if (_mystery_number == guess)
            {
                Console.WriteLine("Correct!");
                Console.WriteLine($"It took {_num_guesses} guesses.");
            }
            else if (_mystery_number > guess)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Lower!");
            }
        }
        while (_mystery_number != guess);
        DisplayEnd();  // Calls from Parent class
    }
}

// Code Word Game is a type of Game (inheritance)

public class CodeWordGame : Game
{
    private string _word;

    // CodeWordGame constructor calls the Game constructor
    public CodeWordGame() : base("Code Word Game")
    {
        // Randomly select a word
        Random random = new Random();
        List<string> words = new List<string>() {
            "apple", "pear", "orange", "watermelon"
        };
        int index = random.Next(words.Count);
        _word = words[index];
    }

    // Display the start, play the game, and display the end
    // The word is coded by shifting it by 1 letter
    public void Play()
    {
        DisplayStart();  // Calls from Parent class

        string coded = "";
        foreach (char c in _word)
        {
            // Convert the letter to the ASCII number, add 1 to it, then convert
            // it back to a character
            coded += (char)((int) c + 1);
        }
        Console.WriteLine($"Here is the coded word: {coded}");
        Console.Write("What is the uncoded word? ");
        string guess = Console.ReadLine();
        if (guess == _word)
        {
            Console.WriteLine("You got it!");
        }
        else
        {
            Console.WriteLine($"Nope ... the answer was: {_word}");
        }

        DisplayEnd();  // Calls from Parent class
    }
}

class Program
{
    // Simple menu to test out the game classes.
    static void Main(string[] args)
    {
        string choice = "0";
        do
        {
            Console.WriteLine("Game Menu");
            Console.WriteLine("1) Guessing Game");
            Console.WriteLine("2) Code Word Game");
            Console.WriteLine("3) Math Game");
            Console.WriteLine("4) Exit");
            Console.Write("Your choice: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                GuessingGame g = new GuessingGame();
                g.Play();
            }
            else if (choice == "2")
            {
                CodeWordGame g = new CodeWordGame();
                g.Play();
            }
            else if (choice == "3")
            {
                MathGame g = new MathGame();
                g.Play();
            }
        }
        while (choice != "4");
        Console.WriteLine("Goodbye!");
    }
}


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");
        Journal journal = new Journal();
        Entry anEntry = new Entry();
        PromptGenerator promptGenerator = new PromptGenerator();

        string response;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();

            if (response == "1")
            {
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                
                
                
                Console.Write("> ");
                string newEntryText = Console.ReadLine();

                DateTime currentDate = DateTime.Now;
                string dateText = currentDate.ToShortDateString();

                Entry newEntry = new Entry
                {
                    _date = dateText,
                    _promptText = randomPrompt,
                    _entryText = newEntryText
                };
                journal.AddEntry(newEntry);
            }
            else if (response == "2")
            {
                journal.DisplayAll();
            }
            else if (response == "3")
            {
                Console.WriteLine("What is the filename? ");
                string loadFilename = Console.ReadLine();
                Console.WriteLine($"These are the contents of the journal from {loadFilename}.");
                journal.LoadFromFile(loadFilename);
            }
            else if (response == "4")
            {
                Console.WriteLine("What is the filename? ");
                string saveFilename = Console.ReadLine();
                journal.SaveToFile(saveFilename);
                Console.WriteLine($"Journal saved to {saveFilename}.");
            }
            else if (response == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid choice (1, 2, 3, 4, or 5).");
            }
        } while (response != "5");
    }
}
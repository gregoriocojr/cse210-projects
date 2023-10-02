using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // var reference = new Reference("John",3,16);
        // var scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Addeed codes so that the program will read from a csv file.
        string csvFilePath = "myScriptureVerses.csv";

        using (TextFieldParser parser = new TextFieldParser(csvFilePath))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");

            parser.ReadLine();

            while (!parser.EndOfData)
            {
                string[] row = parser.ReadFields();
                if (row.Length == 5)
                {
                    string book = row[0].Trim();
                    int chapter = int.Parse(row[1]);
                    int verse = int.Parse(row[2]);
                    int endVerse = int.TryParse(row[3], out int parsedEndVerse) ? parsedEndVerse : 0;
                    string scriptureText = row[4].Trim();

                    var reference = endVerse > 0 ? new Reference(book, chapter, verse, endVerse) : new Reference(book, chapter, verse);
                    var scripture = new Scripture(reference, scriptureText);

                    string input;

                    do
                    {   
                        Console.Clear();
                        Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");
                        Console.WriteLine();
                        Console.WriteLine("Press Enter/Return to continue or type 'quit' to finish:");
                        input = Console.ReadLine();

                        // Added codes so that when the words are completely hidden, the user will be asked if he/she wants to try another verse.
                        if (scripture.IsCompletelyHidden())
                        {
                            Console.Write("All words are hidden. Do you want to try another verse? (yes/no): ");
                            string response = Console.ReadLine().ToLower();

                            if (response == "no")
                            {
                                return;
                            }
                            else if (response == "yes")
                            {
                                break;
                            }
                        }

                        else if (input == "quit")
                        {
                            return;
                        }

                        else
                        {
                            int numberToHide = new Random().Next(2, 6);
                            scripture.HideRandomWords(numberToHide);                    
                        }
                    }
                    while (input != "quit");
                }
            }
        }
    }
}